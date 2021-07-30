using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Prova5Prodotti
{
    class Program
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Magazzino;Trusted_Connection=True;";

        DataService ds = new DataService();

        static void Main(string[] args)
        {

            using (SqlConnection conn = new(connectionString))
            {
                conn.Open();


                Console.WriteLine(" Lista Magazzino ");
                SqlCommand leggi = new();
                leggi.Connection = conn;
                leggi.CommandType = System.Data.CommandType.Text;
                leggi.CommandText = "SELECT * FROM Prodotti";

               DataService ds = new(connectionString);

               ds.Init();  

                Console.WriteLine("Prima lista");
               ds.ListaProdotti();


                DataService.AggiungiProdotti = new Prodotti()
                {
                    CodiceProdotto = "PR09",
                    Categoria = "Alimentari",
                    Descrizione = "Patatine",
                    PrezzoUnitario = "2",
                    QuantitaDisponibili = "10"
                };

                Console.WriteLine("ID: ");
                string id = Console.ReadLine();
                int.TryParse(id, out int ID);

                DataService.RimuoviProdotti(ID);
                {

                }

                DataService.Aggiorna();
                {

                }




            }
        }
    }
}


