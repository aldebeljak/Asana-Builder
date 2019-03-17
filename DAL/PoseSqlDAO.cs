using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AsanaBuilder.Models;

namespace AsanaBuilder.DAL
{
    public class PoseSqlDAO : IPoseDAO
    {
        public string ConnectionString { get; set; }
        public PoseSqlDAO(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public IList<Pose> GetAllPoses()
        {
            IList<Pose> poses = new List<Pose>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from poses", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Pose pose = ConvertReaderToPose(reader);
                        poses.Add(pose);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return poses;
        }

        private Pose ConvertReaderToPose(SqlDataReader reader)
        {
            Pose pose = new Pose();
            pose.Id = Convert.ToInt32(reader["id"]);
            pose.Name = Convert.ToString(reader["name"]);
            pose.Image = Convert.ToString(reader["image"]);
            pose.Type = Convert.ToString(reader["type"]);
            pose.Description = Convert.ToString(reader["description"]);
            pose.Difficulty = Convert.ToInt32(reader["difficulty"]);

            return pose;
        }

        public bool AddPose(Pose pose)
        {
            throw new NotImplementedException();
        }

        public bool RemovePose(Pose pose)
        {
            throw new NotImplementedException();
        }
    }
}
