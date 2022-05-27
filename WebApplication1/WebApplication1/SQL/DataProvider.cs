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

        public void  Add(Spettatore spettatore)
        {


            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = @"INSERT INTO Spettatore([IdBiglietto],[Nome],[Cognome],[Età],[Sconto])
                        VALUES(@IdBiglietto,@Nome,@Cognome,@età,@Sconto)";
                                  
            
            
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Nome", spettatore.Nome);
                command.Parameters.AddWithValue("Cognome", spettatore.Cognome);
                command.Parameters.AddWithValue("Età", spettatore.Età);
                command.Parameters.AddWithValue("IdBiglietto", spettatore.IdBigliettoS);
            command.Parameters.AddWithValue("Sconto", spettatore.Sconto);

            command.ExecuteNonQuery();
        }



        public bool CheckPosti(SalaCinematografica sala)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var query = @"select count(*)
                       from SalaCinematografica 
                       where PostiDisponibili =0;";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PostiDisponibili",sala.PostiDisponibili);
          

            return Convert.ToInt32(command.ExecuteScalar()) == 1;



        }
        public void MesaagioP()
        {
            throw new FileNotFoundException(@"Posti Pieni ");



        }
}
}
