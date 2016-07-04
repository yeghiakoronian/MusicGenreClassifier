using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP_Genre_Recogition
{
    class FetchFromDB
    {
        MySqlConnection Connection = new MySqlConnection("host=localhost;user=root;password=1234;database=genrerecognition;");
        String TemplateQuery;
      
        public DataTable getTrainingDataFor(String TABLE, int TrainORTest)
        {
            DataTable dataTable = new DataTable();
            TemplateQuery = "SELECT LYRICS FROM " + TABLE + " WHERE ISTRAINING='"+TrainORTest+ "';";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;
        }


        public DataTable getTrainingDataFor(String tablename)
        {
            DataTable dataTable = new DataTable();
            TemplateQuery = "SELECT * FROM " + tablename + " ;";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;
        }


        public DataTable getProbabilityDataFor(String ProbabilityTable,Double delta)
        {
            DataTable dataTable = new DataTable();
            int vocabCount = getVocabularyCount();
            TemplateQuery = " select word,CAST((frequency+"+delta+")/(select (count(1)+"+ delta*vocabCount+" ) from " + ProbabilityTable + ") as DECIMAL(25,7)) from "+ProbabilityTable+"  ;";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;
        }


        public int getTotalFrequency()
        {
            DataTable dataTable = new DataTable();
            int totalFrequency = 0;
            TemplateQuery = "SELECT COUNT(1) FROM RAPRAW where istraining='1' UNION SELECT COUNT(1) FROM COUNTRYRAW where istraining='1' UNION SELECT COUNT(1) FROM RELIGIONRAW where istraining='1' UNION SELECT COUNT(1) FROM ROCKRAW where istraining='1' UNION SELECT COUNT(1) FROM REGGAERAW where istraining='1';";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            foreach (DataRow row in dataTable.Rows) // Loop over the rows.
                foreach (var item in row.ItemArray) // Loop over the items.
                    totalFrequency = totalFrequency + Convert.ToInt16(item);
            return totalFrequency;
        }


        public DataTable getVocabulary()
        {
            DataTable dataTable = new DataTable();
            TemplateQuery = " SELECT WORD FROM VOCABULARY;";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;
         }


        public int getVocabularyCount()
        {
            DataTable dataTable = new DataTable();
            int countVocab = 0;
            TemplateQuery = " SELECT Count(1) FROM VOCABULARY;";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            countVocab = Convert.ToInt32(dataTable.Rows[0][0]);
            closeConnection();

            return countVocab;
           
        }



        public int getFrequency(String FrequencyTable)
        {
            int Frequency = 0;
            DataTable dataTable = new DataTable();
            TemplateQuery = "SELECT COUNT(1) FROM " + FrequencyTable +  " WHERE ISTRAINING='1';";
            MySqlCommand Command = new MySqlCommand(TemplateQuery, Connection);
            Connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            closeConnection();
            foreach (DataRow row in dataTable.Rows) // Loop over the rows.
                foreach (var item in row.ItemArray) // Loop over the items.
                    Frequency = Frequency + Convert.ToInt16(item);
            return Frequency;
        }


        public Double[] getProbabilitiesOfAllGenres(String[] Genres)
        {
            Double[] probabilityGenres = new Double[Genres.Length];
            String[] rawTables = { "rapraw", "countryraw", "religionraw", "rockraw", "reggaeraw" };
            int totalFrequency = getTotalFrequency();
            for (int i = 0; i < Genres.Length; i++)
            { 
                Double probability = Convert.ToDouble(getFrequency(rawTables[i])) / totalFrequency;
                probabilityGenres[i] = Math.Round(probability,7);
              }  
            
            return probabilityGenres;
        }





        public void closeConnection()
        {
            if (Connection != null)
                Connection.Close();
        }
    }
}
