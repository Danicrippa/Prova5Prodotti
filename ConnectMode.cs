using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Prova5Prodotti
{
    public class ConnectedMode
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Magazzino;Trusted_Connection=True;";

        public string insert;

        internal class AddWithValue { }


        public static void ElencaProdotti()
        {
            using (SqlConnection conn = new(connectionString))
            {
                conn.Open();


                SqlCommand leggi = new();
                leggi.Connection = conn;
                leggi.CommandType = System.Data.CommandType.Text;
                leggi.CommandText = "SELECT * FROM Prodotti";

                SqlCommand leggi2 = new("SELECT * FROM Prodotti", conn);
                leggi2.CommandType = System.Data.CommandType.Text;


                SqlDataReader reader = leggi2.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("ID", "CodiceProdotto", "Categoria", "Descrizione", "PrezzoUnitario", "QuantitaDisponibili");


                while (reader.Read())  
                {
                    int i = reader.GetInt32(0);

                    Console.WriteLine(
                      (string)reader["ID"],
                        reader["CodiceProdotto"],
                        reader["Categoria"],
                        reader["Descrizione"],
                        reader["PrezzoUnitario"],
                        reader["QuantitaDisponibili"]
                    );
                }

                public static void insertProdotti()
                {
                    using (SqlConnection conn = new(connectionString))
                    {
                        conn.Open();

                        string insertCommand = "INSERT INTO Prodotti VALUES{(@ID, @CodiceProdotto, @Categoria, @Descrizione, @PrezzoUnitario, @QuantitaDisponibili)";

                        string insertParameters.AddWithValue("@ID", "@CodiceProdotto", "@Categoria", "@Descrizione", "@PrezzoUnitario", "QuantitaDisponibili");


                        Console.WriteLine("ID: ");
                        string ID = Console.ReadLine();


                        Console.WriteLine("CodiceProdotto");
                        string CodiceProdotto = Console.ReadLine();


                        Console.WriteLine("Categoria");
                        string Categoria = Console.ReadLine();


                        Console.WriteLine("Descrizione");
                        string Descrizione = Console.ReadLine();


                        Console.WriteLine("PrezzoUnitario");
                        decimal PrezzoUnitario = decimal.Parse(Console.ReadLine());


                        Console.WriteLine("QuantitaDisponibili"));
                int QuantitaDisponibili = int.Parse(Console.ReadLine());


                int result = insertExecuteNonQuery();

                if (result != 1)
                    Console.WriteLine("Errore di inserimento dati.");

                Console.Write("Premi un tasto ...");
                Console.ReadLine();

                conn.Close();


                
               

                

            }
        }
    }
}

