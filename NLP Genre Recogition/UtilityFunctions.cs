using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP_Genre_Recogition
{
    class UtilityFunctions
    {
        RegexDataParser RDP = new RegexDataParser();
        string[] stopWords ;
        public UtilityFunctions()
        {
            string words= "the,it,its,in,youre,your,shes,our,this,her,his,him,i,am,you,are,he,she,is,they,we,was,were,can,shall,will,could,should,would" +
                     "not,if,of,your,im,but,dont,if,so,for,there,not,up,do,ive,id,no,as,at,yes,and,a,my,me,on,that,be,to,been,have,had,shouldnt,couldnt,wouldnt,cant,wont,arent,isnt, ,,";
            stopWords = words.Split(',');
        }
        public Hashtable TableToHashSumAdded(DataTable Table)
        {

            Hashtable tableTOReturn = new Hashtable();
            for (int row = 0; row < Table.Rows.Count; row++)
            {
                String[] lyrics = RDP.StripTagsRegexCompiled(Table.Rows[row][0].ToString()).Split(' ');
                for (int i = 0; i < lyrics.Length; i++)
                {
                    if (tableTOReturn.ContainsKey(lyrics[i]))
                        tableTOReturn[lyrics[i]] = (int)tableTOReturn[lyrics[i]] + 1;
                    else
                        tableTOReturn.Add(lyrics[i], 1);
                }

            }
            return tableTOReturn;
        }


        public Hashtable initTable(Hashtable table)
        {
            Hashtable newHashTable = new Hashtable();
            foreach (String key in table.Keys)
                newHashTable.Add(key, 0);
            return newHashTable;
        }


        public Hashtable TableToHash(DataTable Table)
        {

            Hashtable tableTOReturn = new Hashtable();
            for (int row = 0; row < Table.Rows.Count; row++)
            {


                tableTOReturn.Add(Table.Rows[row][0].ToString(), Math.Round(Convert.ToDouble(Table.Rows[row][1]),7));
                

            }
            return tableTOReturn;
        }


        public Hashtable TableToHashforFullRaw(DataTable Table)
        {

            Hashtable tableTOReturn = new Hashtable();
            for (int row = 0; row < Table.Rows.Count; row++)
            {


                tableTOReturn.Add(Table.Rows[row][0].ToString(), 0);


            }
            return tableTOReturn;
        }


        public Hashtable removeStopWords(Hashtable hashTable)
        {
           // Hashtable newTable = new Hashtable();
            Hashtable stopWords = getStopWordList();
           foreach (DictionaryEntry entry in stopWords)
            {
                if (hashTable.ContainsKey(entry.Key))
                    hashTable.Remove(entry.Key);
            }
           return hashTable;
        }


        public Double[] getRowCount(Double[,] confusionMatrix)
        {
            Double[] rowCount = new Double[Convert.ToInt16(Math.Pow(confusionMatrix.Length,0.5))];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5;j++ )
                    rowCount[i] = rowCount[i] + confusionMatrix[i, j];
            return rowCount;
                
        }

        public Hashtable getStopWordList()
        {
           // string path = "";
            Hashtable stopwords = new Hashtable();
            StreamReader objReader = new StreamReader("English.txt", Encoding.GetEncoding("iso-8859-1"));
            string sLine = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();


                if (sLine != null)
                    if (sLine.Length > 0)
                    {
                        String[] words = sLine.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (!stopwords.ContainsKey(words[i].ToLower()))
                                stopwords.Add(words[i].ToLower(), words[i].ToLower());
                        }
                    }
            }
            return stopwords;
        }
    }
}
