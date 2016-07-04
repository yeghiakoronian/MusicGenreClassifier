using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace NLP_Genre_Recogition
{
    class mainFormFunctions
    {

        String[] rawTables = { "rapraw", "countryraw", "religionraw", "rockraw", "reggaeraw" };
        String[] freqTables = { "rapfrequency", "countryfrequency", "religionfrequency", "rockfrequency", "reggaefrequency" };
        Double[,] confusionMatrix = new Double[5, 5];
        ProgressBar DBProgressBar;

        public mainFormFunctions(ProgressBar progressBar)
        {
            DBProgressBar = progressBar;
        }

        public mainFormFunctions() { }

        public void testFromDB()
        {
                NaiveBayesClassifier NB;
                RegexDataParser RDP;
                FetchFromDB fetchFromDb;
                UtilityFunctions utilityFunction = new UtilityFunctions();
                Hashtable Vocabulary = utilityFunction.TableToHashSumAdded((new FetchFromDB()).getVocabulary());
                DBProgressBar.ForeColor = Color.Blue;
                DBProgressBar.Value = 0;
                DBProgressBar.Visible = true;
                for (int i = 0; i < freqTables.Length; i++)
                {
                    NB = new NaiveBayesClassifier(freqTables);
                    RDP = new RegexDataParser();
                    fetchFromDb = new FetchFromDB();
                    DataTable dataTable = fetchFromDb.getTrainingDataFor(rawTables[i], 0);
                    foreach (DataRow row in dataTable.Rows) // Loop over the rows.
                        foreach (var item in row.ItemArray) // Loop over the items.
                        {
                            String Lyrics = RDP.StripTagsRegexCompiled(item.ToString());
                            String[] lyric = Lyrics.Split(' ');
                            List<string> containinginVocab = new List<string>();
                            for (int l = 0; l < lyric.Length; l++)
                            {
                                if (Vocabulary.ContainsKey(lyric[l]))
                                    containinginVocab.Add(lyric[l]);
                            }
                            Double[] classification = NB.ApplyBayes(containinginVocab.ToArray());
                            int indx = NB.getMaxConfidence(classification);
                            confusionMatrix[i, indx] = confusionMatrix[i, indx] + 1;
                        }
                    dataTable = null;
                    DBProgressBar.Value = DBProgressBar.Value + 100 / freqTables.Length;
                }
                Double[] rowFrequency = utilityFunction.getRowCount(confusionMatrix);
                Double[,] PercentageMatrix = new Double[rawTables.Length, rawTables.Length];
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        PercentageMatrix[i, j] = (confusionMatrix[i, j] * 100) / rowFrequency[i];
                String[] Genres = { "Rap", "Country", "Religion", "Rock", "Reggae" };
                InsertIntoDB insertMatrix = new InsertIntoDB();
                insertMatrix.insertConfusionMatrix(PercentageMatrix, Genres);
                ReportForm rf = new ReportForm();
                rf.Show();
               

        }

        public void trainFromDB()
        {
            DBProgressBar.ForeColor = Color.Blue;
            for (int i = 0; i < rawTables.Length; i++)
            {
                FetchFromDB Fetch = new FetchFromDB();
                UtilityFunctions UF = new UtilityFunctions();
                DataTable dt = Fetch.getTrainingDataFor(rawTables[i], 1);
                Hashtable ht = UF.TableToHashSumAdded(dt);
                InsertIntoDB insertToDB = new InsertIntoDB();
                insertToDB.InsertDataFor(freqTables[i], ht);
                DBProgressBar.Value = DBProgressBar.Value + 100 / rawTables.Length;
            }
        }

        

        public void getGenreOfSong(String Lyrics)
        {
            NaiveBayesClassifier NB;
            RegexDataParser RDP = new RegexDataParser();
            UtilityFunctions utilityFunction = new UtilityFunctions();
            Hashtable Vocabulary = utilityFunction.TableToHashSumAdded((new FetchFromDB()).getVocabulary());
           
          
                NB = new NaiveBayesClassifier(freqTables);
                Lyrics = RDP.StripTagsRegexCompiled(Lyrics);
                String[] lyric = Lyrics.Split(' ');
                List<string> containinginVocab = new List<string>();
                for (int l = 0; l < lyric.Length; l++)
                {
                    if (Vocabulary.ContainsKey(lyric[l]))
                        containinginVocab.Add(lyric[l]);
                }
                Double[] classification = NB.ApplyBayes(containinginVocab.ToArray());
                int indx = NB.getMaxConfidence(classification);
                MessageBox.Show("Classified as :" + rawTables[indx], "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        public void imageOCRTest(FileDialog openImageDialog )
        {
           
             DialogResult ImageResult = openImageDialog.ShowDialog();
             if (ImageResult == DialogResult.OK)
             {
                 String testImagePath = openImageDialog.FileName;
                 try
                 {
                     using (var tEngine = new TesseractEngine("C:\\Users\\yeghiakoronian\\Documents\\visual studio 2013\\Projects\\NLP Genre Recogition\\NLP Genre Recogition\\tessdata", "eng", EngineMode.Default)) //creating the tesseract OCR engine with English as the language
                     {
                         using (var img = Pix.LoadFromFile(testImagePath)) // Load of the image file from the Pix object which is a wrapper for Leptonica PIX structure
                         {
                             using (var page = tEngine.Process(img)) //process the specified image
                             {
                                 String text = page.GetText(); //Gets the image's content as plain text.
                                 MessageBox.Show(text);
                                 getGenreOfSong(text);
                                 //  Console.ReadKey();                            
                             }
                         }
                     }
                 }
                 catch (IOException)
                 {
                     MessageBox.Show("Woops Cant Open The File", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
             }
        
        }



    }
}
