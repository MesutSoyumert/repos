using System;
using MySql.Data.MySqlClient;

namespace Ders11_MySqlKomutları
{
    internal class Program
    {
        private static MySqlConnection con;
        public static void Main(string[] args)
        {
            basla2:
            MySql_MS();

            Console.Write("Hangi işlemi yapmak istiyorsunuz ? (giris, kayıt): ");
            string komut = Console.ReadLine();

            if (komut == "giris")
            {
                LoginUser();
            }
            else if (komut == "kayıt")
            {
                kullanicikayit();
            }
            else
            {
                Console.WriteLine("Yanlış komut girdiniz, tekrar giriniz");
                goto basla2;
            }
        }
        static void kullanicikayit()
        {
            Console.Write("Kullanıcı Adını Giriniz: ");
            string Kullanici_Adi = Console.ReadLine();

            Console.Write("E-Posta Adresini Giriniz: ");
            string E_Posta = Console.ReadLine();

        Parola_Gir:
            
            Console.Write("Parolanızı Giriniz: ");
            string Paro = Console.ReadLine();

            Console.Write("Parolanızı Tekrar Giriniz: ");
            string Paro_Tekrar = Console.ReadLine();

            if (Paro != Paro_Tekrar)
            {
                Console.WriteLine("Girdiğiniz parolalar aynı değil, tekrar giriniz");
                goto Parola_Gir;
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand Kullanici_Kayit = new MySqlCommand(cmdText: "INSERT INTO users (User_Name, User_Password, User_Mail) VALUES(@Kullanici_Adi, @Paro, @E_Posta)  ", con);
                    Kullanici_Kayit.Parameters.AddWithValue(parameterName: "@Kullanici_Adi", Kullanici_Adi);
                    Kullanici_Kayit.Parameters.AddWithValue(parameterName: "@Paro", Paro);
                    Kullanici_Kayit.Parameters.AddWithValue(parameterName: "@E_Posta", E_Posta);
                    if (Kullanici_Kayit.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("Kullanıcı başarıyla kaydedildi");
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                { Console.WriteLine(ex); }


            }
        }
        static void LoginUser()
        {
            Basla:
                Console.Write("Kullanıcı Adını Giriniz: ");
                string KullaniciAdi = Console.ReadLine();

                Console.Write("Parolayı Giriniz: ");
                string Parola = Console.ReadLine();

                try
                {
                    con.Open();
                    MySqlCommand giris = new MySqlCommand(cmdText: "SELECT * FROM users Where User_Name=@KullaniciAdi", con);
                    giris.Parameters.AddWithValue(parameterName: "@KullaniciAdi", KullaniciAdi);
                    MySqlDataReader oku = giris.ExecuteReader();
                    if (oku.Read())
                    {
                        string GelenParola = oku["User_Password"].ToString();
                        if (Parola != GelenParola)
                        {
                            Console.WriteLine("Parola Hatalı");
                            con.Close();
                            goto Basla;
                        }
                        else
                        {
                            Console.WriteLine("Giriş Başarılı");
                            Console.WriteLine("Mail Adresiniz: " + oku["User_Mail"].ToString());
                            con.Close();
                            goto Basla;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı Bulunamadı");
                        con.Close();
                        goto Basla;
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    goto Basla;
                }
            }
        static void MySql_MS()
            {
                con = new MySqlConnection(
                    "Server=localhost;" +
                    "Database=Ders6;" +
                    "Charset=utf8;" +
                    "Uid=root;" +
                    "Password=''");
            }
        }
    }