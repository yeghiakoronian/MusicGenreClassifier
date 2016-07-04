using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;
using Tesseract;

namespace NLP_Genre_Recogition
{
    public partial class mainForm : Form
    {
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        String[] rawTables = { "rapraw", "countryraw", "religionraw", "rockraw", "reggaeraw" };
        String[] freqTables = { "rapfrequency", "countryfrequency", "religionfrequency", "rockfrequency", "reggaefrequency" };
        Double[,] confusionMatrix = new Double[5, 5];
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        PromptBuilder promtBuilder = new PromptBuilder();
        SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
   
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] { "exit system", "paste document", "open matrix", "open file", "test database", "test image" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
           

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();

            recEngine.SpeechRecognized += sRecognize_SpeechRecognized; //recEngine_SpeechRecognized; 
           // recEngine.RecognizeAsync(RecognizeMode.Multiple);
           

        }

       

       
     
       



        private void ribbon1_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            mainFormFunctions mainFunctions;
             switch (e.Command.Key)
             {
                 case "btn_OpenFileTest":
                      DialogResult dResult = openFileDialogLyric.ShowDialog();
                      String Lyrics = "";
                      String fileName = "";
                      if (dResult == DialogResult.OK)
                      {
                          fileName = openFileDialogLyric.FileName;
                          try
                          {
                              Lyrics = File.ReadAllText(fileName);
                              mainFunctions = new mainFormFunctions();
                              mainFunctions.getGenreOfSong(Lyrics);

                          }
                          catch (IOException)
                          {
                              MessageBox.Show("Woops Cant Open The File", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                          }
                      }
                 break;

                 case "btn_PasteTest":
                    richTextBox.Visible = true;
                    btn_getPaste.Visible = true;
                 
                 break;
                 
                 case "btn_CMatrix":
                      ReportForm rf = new ReportForm();
                     // rf.Activate();
                      rf.TopMost = true;
                      rf.Show();
                      rf.TopMost = true;
                 break;

                 case "btn_DataBaseTest":
                     mainFunctions = new mainFormFunctions(progressBar1);
                     progressBar1.Visible = true;
                     mainFunctions.testFromDB();
                     progressBar1.Visible = false;
                 break;

                 case "btn_ImageOCRTest":
                    mainFunctions = new mainFormFunctions();
                    mainFunctions.imageOCRTest(openImageDialog);

                 break;
                 case "btn_DataTableTest":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;

                 case "btn_VoiceTest":
                 MessageBox.Show("Are you gonna seriously sing a song?", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;


                 case "btn_OpenFileTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_PasteTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_DataTableTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_ScannerOCRTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_CameraOCRTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_ImageOCRTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
                 case "btn_VoiceTrain":
                 MessageBox.Show("Woops not supported Yet", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 break;
               
                 case "btn_DataBaseTrain":
                     DialogResult dialogResult = MessageBox.Show("If training set is already made, running this query will give wrong results, are you sure you want to run?", "Train FROM DB", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (dialogResult == DialogResult.Yes)
                     {
                         mainFunctions = new mainFormFunctions(progressBar1);
                         mainFunctions.trainFromDB();
                     }
                     break;
                
               }
             
        }

        private void btn_getPaste_Click(object sender, EventArgs e)
        {
            btn_getPaste.Visible = false;
            richTextBox.Visible = false;
            mainFormFunctions mainFunctions = new mainFormFunctions();
            mainFunctions.getGenreOfSong(richTextBox.Text.ToString());
            richTextBox.Text = "";
        }


        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show(e.Result.Text);
        }


        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string[] command = e.Result.Text.ToString().Split();
            pBuilder.ClearContent();
            pBuilder.AppendText(command[0]+"ing"+" "+ command[1]+" sir");
            sSynth.Speak(pBuilder);
            if (e.Result.Text == "exit system" )
                Application.Exit();
            else if (e.Result.Text == "paste document")
            {
                richTextBox.Visible = true;
                btn_getPaste.Visible = true;
            }


            else if (e.Result.Text == "test database")
            {
                mainFormFunctions mainFunctions = new mainFormFunctions(progressBar1);
                progressBar1.Visible = true;
                mainFunctions.testFromDB();
                progressBar1.Visible = false;
            }

            if (e.Result.Text == "open matrix")
            {
                ReportForm rf = new ReportForm();
                
                rf.TopMost = true;
                rf.Show();
                rf.TopMost = true;
            }   

            else if (e.Result.Text == "test image")
            {
                mainFormFunctions mainFunctions = new mainFormFunctions();
                mainFunctions.imageOCRTest(openImageDialog);
            }

           
            else if (e.Result.Text == "open file")
            {
                DialogResult dResult = openFileDialogLyric.ShowDialog();
                String Lyrics = "";
                String fileName = "";
                if (dResult == DialogResult.OK)
                {
                    fileName = openFileDialogLyric.FileName;
                    try
                    {
                        Lyrics = File.ReadAllText(fileName);
                        mainFormFunctions mainFunctions = new mainFormFunctions();
                        mainFunctions.getGenreOfSong(Lyrics);

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Woops Cant Open The File", "COMP 6781: NLP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }


               




            
           
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
        }

        private void btn_audioCommandOn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FetchFromDB fb = new FetchFromDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("\"ClASS\",\"ISTRAINING\",");
            UtilityFunctions uf = new UtilityFunctions();
            DataTable voc = fb.getTrainingDataFor("vocabulary");
            DataTable fullraw = fb.getTrainingDataFor("fullraw");
            Hashtable vocab = uf.TableToHashforFullRaw(voc);

            int counter = 1;
            foreach (String key in vocab.Keys)
            {
                if (counter != vocab.Count)
                    sb.Append("\""+key+"\"" + ",");
                else
                    sb.Append("\"" + key + "\"");
                counter++;
            }

            using (StreamWriter sw = new StreamWriter("fullraw.csv"))
            {
                sw.Write(sb+"\n");
            }

            RegexDataParser rdp = new RegexDataParser();
            for (int i = 0; i < fullraw.Rows.Count;i++ )
            {
                Hashtable temp = uf.initTable(vocab);
               
                StringBuilder tempStringBuilder = new StringBuilder();
                tempStringBuilder.Append("\""+fullraw.Rows[i][0]+"\"" + ","); // class
                tempStringBuilder.Append("\""+fullraw.Rows[i][1] + "\"" + ","); // istraining

                String Lyrics = Convert.ToString(fullraw.Rows[i][2]);
                Lyrics = rdp.StripTagsRegexCompiled(Lyrics);
                String[] lyric = Lyrics.Split(' ');

               
                counter = 1;
                foreach (String word in lyric)
                {
                    if (vocab.ContainsKey(word))
                    {
                        temp[word] = Convert.ToInt32(temp[word]) + 1;
                    }
                }

                counter = 1;
                foreach (String key in vocab.Keys)
                {
                    if (counter != vocab.Count)
                        tempStringBuilder.Append("\""+temp[key] + "\"" + ",");
                    else
                        tempStringBuilder.Append("\""+temp[key] + "\"");
                    counter++;
                }
                using (StreamWriter sw = new StreamWriter("fullraw.csv",true))
                {
                    sw.Write(tempStringBuilder+"\n");
                }

                temp = null;
                
            }

        }

      
    }
}
