using System;
using System.Runtime.CompilerServices;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ders6_mysql_komutlari
{
    internal class Program
    {
        private static MySqlConnection con;
        
        public static void Main(string[] args)
        {
            basla2:
            mysql();
            
            Console.Write("Ne işlemi yapmak istiyorsunuz? (login,register): ");
            string komut = Console.ReadLine();

            if (komut == "login")
            {
                loginUser();
            } else if (komut == "register")
            {
                registerUser();
            }
            else
            {
                Console.WriteLine("Komut bulunamadı!");
                goto basla2;
            }

        }

        static void registerUser()
        {
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();

            Console.Write("Email Adres: ");
            string email = Console.ReadLine();
            
            sifregir:
            Console.Write("Şifrenizi Girin: ");
            string pass = Console.ReadLine();
            
            Console.Write("Şifrenizi Tekrar Girin: ");
            string repeatPass = Console.ReadLine();

            if (pass != repeatPass)
            {
                Console.WriteLine("Şifreler uyuşmuyor!");
                goto sifregir;
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand rUser = new MySqlCommand("INSERT INTO users (Username,Userpassword,Usermail) VALUES(@username,@password,@mail)", con);
                    rUser.Parameters.AddWithValue("@username", username);
                    rUser.Parameters.AddWithValue("@password", pass);
                    rUser.Parameters.AddWithValue("@mail", email);
                    if (rUser.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("Kullanıcı başarıyla kaydedildi!");
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        
        static void loginUser()
        {
            basla:
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();
            
            Console.Write("Şifre: ");
            string pass = Console.ReadLine();

            try
            {
                con.Open();
                MySqlCommand giris = new MySqlCommand("SELECT * FROM users WHERE Username = @username", con);
                giris.Parameters.AddWithValue("@username", username);
                MySqlDataReader oku = giris.ExecuteReader();
                if (oku.Read())
                {
                    string gelenSifre = oku["Userpassword"].ToString();
                    if (pass != gelenSifre)
                    {
                        Console.WriteLine("Şifre hatalı!");
                    }
                    else
                    {
                        Console.WriteLine("Başarıyla giriş yaptınız!");
                        Console.WriteLine("Mail Adresiniz: " + oku["Usermail"].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı bulunamadı!");
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        
        static void mysql()
        {
            con = new MySqlConnection(
                "Server=localhost;Database=ders6;charset=utf8;uid=root;password=mysql112113mysql"
            );
        }
    }
}