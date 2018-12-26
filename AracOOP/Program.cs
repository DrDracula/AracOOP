using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil1 = new Otomobil(aracTipi.Kara, "BMW", 1990, "Türkiye", 500,yakitTuru.Benzin);
            otomobil1.calistir();
            otomobil1.DepoDoldur = 40;
            otomobil1.calistir();

            otomobil1.hiziArttir();
            Console.WriteLine(otomobil1.ToString());


            Console.WriteLine(otomobil1.ToString());

            Ucak ucak1 = new Ucak(500, ucakTurleri.Yolcu, 4, 500);
            ucak1.AracTipi = aracTipi.Hava;
            ucak1.BeygirGucu = 800;
            ucak1.Mensei = "Türkiye";
            ucak1.Model = "Boeing";
            ucak1.YakitTuru = yakitTuru.Diger;
            ucak1.Yil = 2005;

            Console.WriteLine(ucak1);
            Console.ReadLine();
        }
    }
    class Otomobil : Arac
    {
        bool calistiMi;
        string renk;
        int kapiSayisi;
        int vitesTipi;
        string kasaTipi;
        int depo;
        int hiz;

        public bool calistir()
        {
            if (depo > 0) calistiMi = true;
            else
                Console.WriteLine("Calismadi");
            return calistiMi;
        }
        public bool durdur()
        {
            if (calistiMi = true)
            {
                calistiMi = false;
                hiz = 0;
            }
            else
            {
                Console.WriteLine("Depo bos! Yakıt alınız!!");
            }
            return calistiMi;
        }
        public int hiziArttir()
        {
            if (calistiMi = true)
                hiz += 10;
            else
                Console.WriteLine("Arac Calismiyor.");
            return hiz;
        }
        public int DepoDoldur
        {
            set
            {
                depo += value;
                if (value <= 80 && value >= 0)
                {

                    Console.WriteLine($"Depo su anda {depo} lt oldu. {value} lt yakit alindi");
                }
                else
                    Console.WriteLine("Alinan yakit depo hacminden fazladir.");
            }
        }
        public void Durum()
        {
            string c = calistiMi ? "Calisiyor" : "Calismiyor";

            Console.WriteLine($"Arac su anda {c} ve hizi {hiz} km depoda {depo} lt yakit var");

        }
        public override string ToString()
        {
            string str;
            str = base.ToString();
            return str;
        }
        public Otomobil(aracTipi aracTipi, string model, int yil, string mensei, int beygirGucu,yakitTuru yakitTuru)
        {
            AracTipi=aracTipi;
            Model = model;
            Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            YakitTuru = yakitTuru;
        }
        public Otomobil()
        {

        }
    }

    class Arac
    {
        aracTipi aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        yakitTuru yakitTuru;
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Arac Modeli : {Model}");
            sb.AppendLine($"Arac Yili : {Yil}");
            sb.AppendLine($"Arac Mensei : {Mensei}");
            sb.AppendLine($"Arac tipi : {AracTipi}");
            sb.AppendLine($"Beygir Gucu : {BeygirGucu}");
            sb.AppendLine($"Yakit Turu : {YakitTuru}");
            
            return sb.ToString();
        }
        public int Yil
        {
            get
            {
                return yil;
            }

            set
            {
                if (value >= 1908 && value <= DateTime.Now.Year)
                {
                    yil = value;
                }
                else
                {
                    Console.WriteLine($"Arac 1908 yilindan kucuk ve bulundugu yildan daha buyuk olamaz");
                }
            }
        }
        public aracTipi AracTipi
        {
            get
            {
                return aracTipi;
            }
            set
            {
                aracTipi = value;
            }
        }
        public yakitTuru YakitTuru
        {
            get
            {
                return yakitTuru;
            }
            set
            {
                yakitTuru = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Mensei
        {
            get
            {
                return mensei;
            }

            set
            {
                mensei = value;
            }
        }
        public int BeygirGucu
        {
            get
            {
                return beygirGucu;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    beygirGucu = value;
                }
                else
                {
                    Console.WriteLine("Beygir gucu 0-1000 arasında olmalıdır.");
                }
            }
        }

    }

    class Ucak : Arac
    {
        int yolcuSayisi;
        ucakTurleri ucakTuru;
        int motorSayisi;
        int hiz;
        public Ucak(int yolcuSayisi,ucakTurleri ucakTuru,int motorSayisi,int hiz)
        {
            this.yolcuSayisi = yolcuSayisi;
            this.ucakTuru = ucakTuru;
            this.motorSayisi = motorSayisi;
            this.hiz = hiz;

        }
        
        public override string ToString()
        {
            string str;
            str = base.ToString();
            Console.WriteLine($"Yolcu Sayisi : {yolcuSayisi}\n Ucak Turu : {ucakTuru}\nMotor Sayisi : {motorSayisi}\n Hızı : {hiz}");
            return str;
        }

    }

    enum aracTipi
    {
        Kara = 1, Deniz = 2, Hava = 3

    }
    enum yakitTuru
    {
        Benzin = 1, Mazot = 2, Elektrik = 3, Lpg = 4, Nukleer = 5, Ruzgar = 6, Diger = 7
    }
    enum ucakTurleri
    {
        Yolcu=1,Savas=2,Kargo=3,Tarim=4,Kesif=5
    }
}
