using System;
using System.Data.SqlClient;

namespace CreateTableDBHomework.Data
{
    public class GruppaDataAccess : IDisposable
    {
        private readonly SqlConnection connection;

        public GruppaDataAccess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Server = DESKTOP-6543DI3; Database =ConnectedLevelLesson; Trusted_Connection=True; ";
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
        }

        public void CreateTable()
        {
            var createTableSqlSqcript = $"create table gruppa ( Id int primary key identity(1,1) not null, Name NVARCHAR(max))";

            using (var command = new SqlCommand(createTableSqlSqcript, connection))
            {
                command.ExecuteNonQuery();
            }           
        
        }
    }
}
