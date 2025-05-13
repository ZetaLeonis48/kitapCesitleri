using kitaplar;
namespace kitapCesitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            Kitap kitap1 = new Kitap();
            kitap1.Adi = "Recaizade Mahmut Ekrem";
            kitap1.BasimYili = 1988;
            kitap1.YazarAdi = "Recaizade Mahmut Ekrem";
            kitap1.Stok = 12;

            Kitap kitap2 = new Kitap();
            kitap2.Adi = "Saatleri Ayarlama Enstitüsü";
            kitap2.BasimYili = 1961;
            kitap2.YazarAdi = "Ahmet Hamdi Tanpınar";
            kitap2.Stok = 6;

            kitaplar.Add(kitap1);
            kitaplar.Add(kitap2);

            foreach (var kitap in kitaplar)
            {
                Console.WriteLine("Adı: " + kitap.Adi);
                Console.WriteLine("Basım Yılı: " + kitap.BasimYili);
                Console.WriteLine("Yazar: " + kitap.YazarAdi);
                Console.WriteLine("Stok: " + kitap.Stok);
                
            }

            
        }
    }
}
