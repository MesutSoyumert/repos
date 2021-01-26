using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ders5_mysql_temel
{
    class Program
    {
        private static MySqlConnection con;
        
        static void Main(string[] args)
        {
            mysql_baglanti();
            
            Console.ReadKey();
        }

        static void mysql_baglanti()
        {
            con = new MySqlConnection("Server=localhost;Database=ders5;charset=utf8;uid=root;password=mysql112113mysql");
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("MYSQL Veritabanına Bağlanıldı!");
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}