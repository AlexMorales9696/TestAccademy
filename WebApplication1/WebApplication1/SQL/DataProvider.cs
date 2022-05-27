using WebApplication1.Model;
using System.Data.SqlClient;
namespace WebApplication1.SQL
{
    public class DataProvider : IDataProvider
    {

        private readonly string _connectionString;
        public DataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Add(Spettatore spettatore)
        {
            var query = @"INSERT INTO Spectators
                                   ([Nome]
                                   ,[Cognome]
                                   ,[Età]
                                    ,[IdBiglietto])
                             VALUES
                                   (@Nome
                                   ,@Cognome
                                   ,@età
                                   ,@IdBigliettoS";
            
            
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Name", spettatore.Nome);
                command.Parameters.AddWithValue("Cognome", spettatore.Cognome);
                command.Parameters.AddWithValue("Età", spettatore.Età);
                command.Parameters.AddWithValue("IdBiglietto", spettatore.IdBigliettoS);

            return Convert.ToInt32(command.ExecuteScalar());
            }
            

        }



    }

