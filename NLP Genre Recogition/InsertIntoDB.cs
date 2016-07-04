using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP_Genre_Recogition
{
    class InsertIntoDB
    {
        MySqlConnection Connection = new MySqlConnection("host=localhost;user=root;password=1234;database=genrerecognition;");
        UtilityFunctions uFunctions = new UtilityFunctions();


        public void InsertDataFor(String Table, Hashtable hashTable)
        {
            hashTable = uFunctions.removeStopWords(hashTable);
            
            StringBuilder sCommand = new StringBuilder("INSERT INTO ").Append(Table).Append(" (WORD, FREQUENCY) VALUES ");
            StringBuilder command2 = new StringBuilder();
            List<string> Rows = new List<string>();
            foreach (DictionaryEntry entry in hashTable)
            {
                Rows.Add(string.Format("('{0}','{1}')", entry.Key, entry.Value));
                command2.Append(string.Format("INSERT IGNORE INTO VOCABULARY VALUES ('{0}');", entry.Key));
            }
            sCommand.Append(string.Join(",", Rows));
            sCommand.Append(";");
            Connection.Open();
            using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), Connection))
            {
                myCmd.CommandType = CommandType.Text;
                myCmd.CommandTimeout = 0;
                myCmd.ExecuteNonQuery();
            }

            Connection.Close();
            Connection.Open();
            using (MySqlCommand myCmd = new MySqlCommand(command2.ToString(), Connection))
            {
                myCmd.CommandType = CommandType.Text;
                myCmd.CommandTimeout = 0;
                myCmd.ExecuteNonQuery();
            }
            Connection.Close();

        }


        public void insertConfusionMatrix(Double[,] PercentageMatrix, String[] Genres)
        {
            String truncateCommand = "TRUNCATE TABLE CONFUSIONMATRIX;";
            Connection.Open();
            using (MySqlCommand myCmd = new MySqlCommand(truncateCommand, Connection))
            {
                myCmd.CommandType = CommandType.Text;
                myCmd.CommandTimeout = 0;
                myCmd.ExecuteNonQuery();
            }
            Connection.Close();


            String InsertCommand = "INSERT INTO CONFUSIONMATRIX (BLANK,RAP,COUNTRY,RELIGION,ROCK,REGGAE) VALUES(";
            string subCommand = "";
            int Incrementer = 0;
            while (Incrementer < Genres.Length)
            {
                subCommand = subCommand + "'"+Genres[Incrementer]+"',";
                for (int i = 0; i < Genres.Length; i++)
                   subCommand = subCommand + "'"+Math.Round(PercentageMatrix[Incrementer,i],2)+"',";
                subCommand = subCommand.Substring(0,subCommand.LastIndexOf(',')-1);
                subCommand = subCommand + "'),(";
               
                Incrementer++;
            }
         
            subCommand = subCommand.Substring(0, subCommand.LastIndexOf(',') - 1);
            InsertCommand = InsertCommand + subCommand + ");";
           
                Connection.Open();
                using (MySqlCommand myCmd = new MySqlCommand(InsertCommand, Connection))
            {
                myCmd.CommandType = CommandType.Text;
                myCmd.CommandTimeout = 0;
                myCmd.ExecuteNonQuery();
            }
            Connection.Close();



        }
         
    }
}
