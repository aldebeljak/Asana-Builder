using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AsanaBuilder.Models;

namespace AsanaBuilder.DAL
{
    public class SequenceSqlDAO : ISequenceDAO
    {
        public string ConnectionString { get; set; }
        public SequenceSqlDAO(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public IList<Sequence> GetAllSequences()
        {
            IList<Sequence> sequences = new List<Sequence>();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AsanaBuilder;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM sequences", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Sequence sequence = ConvertReaderToSequence(reader);
                        sequences.Add(sequence);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return sequences;
        }

        private Sequence ConvertReaderToSequence(SqlDataReader reader)
        {
            Sequence sequence = new Sequence();
            sequence.Id = Convert.ToInt32(reader["id"]);
            sequence.Name = Convert.ToString(reader["name"]);
            sequence.User_Id = Convert.ToInt32(reader["user_id"]);
            return sequence;
        } 

        public IList<Pose> GetSequencePoses()
        {
            throw new NotImplementedException();
        }

        public bool CreateSequence(Sequence sequence)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSequence(Sequence sequence)
        {
            throw new NotImplementedException();
        }
    }
}
