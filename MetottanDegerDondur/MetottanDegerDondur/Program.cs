using System;

namespace MetottanDegerDondur
{

	public class VTParOlus
	{

		public String VT_Bağlanti_Parametresi;
		
		// void olarak tanımlanan bir metot herhangi bir değer geriye döndürmez.
		// Taşıtın bilgilerini ekrana yazdıran metot
		public void VT_Baglan()
		{
			String VT_Sunucu_Etiket = "Server=";
			String VT_Sunucu_IP = "127.0.0.1";
			String VT_VeriTabani_Etiket = "Database=";
			String VT_VeriTabaniAdi = "Ders6";
			String VT_KarakterSeti_Etiket = "Charset=";
			String VT_KarakterSeti_ID = "utf8";
			String VT_Kullanici_Adi_Etiket = "Uid=";
			String VT_Kullanici_Adi = "root";
			String VT_Parola_Etiket = "Pwd=";
			String VT_Parola = "''";

			String VT_Bağlanti_Parametresi = VT_Sunucu_Etiket + VT_Sunucu_IP + ";" +
											 VT_VeriTabani_Etiket + VT_VeriTabaniAdi + ";" +
											 VT_KarakterSeti_Etiket + VT_KarakterSeti_ID + ";" +
											 VT_Kullanici_Adi_Etiket + VT_Kullanici_Adi + ";" +
											 VT_Parola_Etiket + VT_Parola;
			Console.WriteLine(VT_Bağlanti_Parametresi);
		}

		// return ile değer döndürebiliriz
		// Burada dikkat edilecek bir nokta ise dönen değer ile dönüş tipi aynı olmalıdır
		// Örneğin, eğer bir metot int veri tipinde tanımlanmış ise 
		//double bir değer döndüremez

		// Burada hiz int 
		public int getHiz()
		{
			return hiz;
		}

		public String getMarka()
		{
			return marka;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Taşıt tipinden nesneler oluşturuyoruz
			Tasit otomobil = new Tasit();
			Tasit motor = new Tasit();
			Tasit tir = new Tasit();

			// otomobil'in hız değişkenine değer atıyoruz
			otomobil.marka = "BMW";
			otomobil.renk = "Siyah";
			otomobil.hiz = 300;
			motor.marka = "Honda";
			motor.renk = "Gri";
			motor.hiz = 250;
			tir.marka = "Volvo";
			tir.renk = "Kırmızı";
			tir.hiz = 180;

			otomobil.tasitInfo();
			motor.tasitInfo();
			tir.tasitInfo();

			// Otomobil nesnemizin hızını çağırıyoruz 
			System.Console.WriteLine("Sadece Otomobilin Hızı: " + otomobil.getHiz().ToString());
			// tır nesnemizin markasını çağırıyoruz
			System.Console.WriteLine("Sadece Tırın Markası: " + tir.getMarka());

		}
	}
}
