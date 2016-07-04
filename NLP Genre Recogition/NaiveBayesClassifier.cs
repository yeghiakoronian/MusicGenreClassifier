using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP_Genre_Recogition
{
        class NaiveBayesClassifier
        {
            
            FetchFromDB fetchFromDB = new FetchFromDB();
            UtilityFunctions utilityFunctions = new UtilityFunctions();
            Double[] getProbabilitiesOfAllGenres;
            String[] Genre;
           
           // Dictionary<String, LanguageObject> gramDictionary;

            public NaiveBayesClassifier(String[] Genre)
            {
                this.getProbabilitiesOfAllGenres = fetchFromDB.getProbabilitiesOfAllGenres(Genre);
                this.Genre = Genre;
              //  this.gramDictionary = gramDictionary;
            }


            public Double[] ApplyBayes(String[] Lyrics)
            {
                Double[] Confidence = new Double[Genre.Length];
                int totalVocabCount = fetchFromDB.getVocabularyCount();
                for (int i = 0; i < Genre.Length; i++)
                {
                    Confidence[i] = Math.Log10(getProbabilitiesOfAllGenres[i]);

                    DataTable tempDatatable = fetchFromDB.getProbabilityDataFor(Genre[i],0.1);
                    Hashtable temp = utilityFunctions.TableToHash(tempDatatable);

                    double totalprobs = 0.0;
                     String x="";
                    for (int j = 0; j < Lyrics.Length; j++)
                    {

                        string word = Lyrics[j];
                        Double probOfWord = 0.0;
                        if (!temp.ContainsKey(word))
                            probOfWord = Math.Log10(Math.Round(0.1 / (temp.Count + 0.1 * totalVocabCount),15));
                        else
                            probOfWord = Math.Log10(Math.Round(Convert.ToDouble( temp[word]),15));
                      //  x =x + word + "  " + temp[word] + "  " + probOfWord +"\n";
                        totalprobs += probOfWord;
                    }
                   // Console.WriteLine(x);
                   // Console.WriteLine(totalprobs);
                   
                    Confidence[i] = Confidence[i] + totalprobs;
                   // Console.Write("asfsdf");
                }
                return Confidence;

            }


            public int getMaxConfidence(Double[] arrayOfConfidence)
            {
                double maxValue = arrayOfConfidence.Max();
                int maxIndex = arrayOfConfidence.ToList().IndexOf(maxValue);
                return maxIndex;
            }


           
        }
    
}
