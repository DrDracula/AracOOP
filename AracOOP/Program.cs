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
            Otomobil otomobil1 = new Otomobil(aracTipi.Kara, "BMW", 1990, "Türkiye", 500);
            otomobil1.calistir();
            otomobil1.DepoDoldur = 40;
            otomobil1.calistir();

            otomobil1.hiziArttir();
            Console.WriteLine(otomobil1.ToString());


            Console.WriteLine(otomobil1.ToString());
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
            str = $"Arac Modeli : {Model} \n Arac yili :{Yil}\n Mensei :{Mensei}\n Arac Tipi :{AracTipi}\n Beygir Gucu :{BeygirGucu}";
            return str;
        }
        public Otomobil(aracTipi aracTipi, string model, int yil, string mensei, int beygirGucu)
        {
            AracTipi=aracTipi;
            Model = model;
            Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
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
        int yakitTuru;

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
        public int YakitTuru
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

    enum aracTipi
    {
        Kara = 1, Deniz = 2, Hava = 3

    }
    enum yakitTuru
    {
        Benzin = 1, Mazot = 2, Elektrik = 3, Lpg = 4, Nukleer = 5, Ruzgar = 6, Diger = 7
    }
}
