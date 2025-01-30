using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        ///!!! NOT Çözümün içine 2. projeyi eklediğinde yukarıdaki Start'ın solundaki proje adına tıklayarak proje adını değiştirebiliriz. 
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number =4.85;//Kod tarafında nokta olarak yazdığımız . ayırma ya da basamak olarak girdiğimiz karakter
            ////console ekranında , olarak karşılanıyor. 


            //Console.WriteLine(number);

            //Console.WriteLine("******** Fiyat Listesi ************");

            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice =45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--------- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("--------- Elma Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("--------- Elma Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("--------- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("--------- Elma Birim Fiyatı:" + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;



            //Console.WriteLine("Alınan Ürün: Elma -: "+"Birim Fiyat: "+applePrice+" - Gramaj: "+ appleGram +" - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -: " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -: " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -: " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -: " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice+ " TL");

            #endregion


            #region Char Değişkenler

            //Sezar şifreleme
            //Metindeki her bir karakterin alfabedeki(Türkçe karakterler hariç) 3 karakter sonrasındakiyle değiştirilmesi
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE 
            //Normal string değişkenler çift tırnakla " char değişkenler tek tırnak 'la tanımlanır

            //char symbol;
            //symbol= 'a';
            //Console.WriteLine(symbol);



            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("******     CSharp Hava Yolları Yolcu Bilgisi     **********");
            //Console.WriteLine();
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerIdentityNumber +" - Yolcu Ad Soyad: "+ passengerName +" "+passengerSurname + " "+ passengerDistrict + " / "+ passengerCity + " "+ passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //Uçak bilet numarası, örneğin ABC12D şeklindedir. Fakat bu karakterlerin içindeki 
            //12 kısmını uygulama harf olarak almaktadır. 
            //İlk giriştede bu veriler sayı olarak algılanmadığı için int dönüştürmek gerekiyor. 


            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice =1000;
            //computerPrice =20000;
            //chairPrice =5000;
            //tvPrice =12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığını ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());//int dönüşümüdür

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + 
            //    chairCount * chairPrice +
            //    tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gtereken tutar: "+totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion


            Console.Read();





        }
    }
}
