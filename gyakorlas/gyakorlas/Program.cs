using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static string[] Honapok = new string[7];
        static int[] Koltseg = new int[7];
        static int[] Szamok = new int[120];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Futesszezon();
            Gyakorlas2();
            Console.ReadKey();
        }

        private static void Gyakorlas2()
        {
            Feladat2Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat3Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat4Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat5Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat6Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat7Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat8Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat9Gyak(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat10Gyak(); Console.WriteLine("\n---------------------------------------------\n");
        }

        private static void Feladat10Gyak()
        {
            Console.WriteLine("Hány elem nagyobb mint 28");
            int db28 = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]>28)
                {
                    db28++;
                }
            }
            Console.WriteLine("Ennyi alkalommal volt 28-nál nagyobb egy tömb elemének értéke: {0}",db28);
        }

        private static void Feladat9Gyak()
        {
            Console.WriteLine("Rendezzük növekvő sorba az elemeket");
            int CsereSzam;
            for (int i = 0; i < Szamok.Length - 1; i++)
            {
                for (int j = 0; j < Szamok.Length - 1; j++)
                {
                    if (Szamok[j] > Szamok[j + 1])
                    {
                        CsereSzam = Szamok[j];
                        Szamok[j] = Szamok[j + 1];
                        Szamok[j + 1] = CsereSzam;
                    }
                }
            }
            Console.WriteLine("Elemek kiiratása 12 elem egy sorba");
            for (int i = 0; i < Szamok.Length; i++)
            {
                if (i % 12 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("\t{0} , ", Szamok[i]);
            }
        }

        private static void Feladat8Gyak()
        {
            Console.WriteLine("Rendezzük csökkenő sorba az elemeket");
            int CsereSzam;
            for (int i = 0; i < Szamok.Length-1; i++)
            {
                for (int j = 0; j < Szamok.Length-1; j++)
                {
                    if(Szamok[j]<Szamok[j+1])
                    {
                        CsereSzam = Szamok[j];
                        Szamok[j] = Szamok[j + 1];
                        Szamok[j + 1] = CsereSzam;
                    }
                }
            }
            Console.WriteLine("Elemek kiiratása 12 elem egy sorba");
            for (int i = 0; i < Szamok.Length; i++)
            {
                if (i % 12 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("\t{0} , ", Szamok[i]);
            }
        }

        private static void Feladat7Gyak()
        {
            Console.WriteLine("Átlag számítás");
            int Osszeg = 0;
            double Atlag =0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                Osszeg += Szamok[i];

            }
            Atlag = (double)Osszeg / Szamok.Length;
            Console.WriteLine("A tömb elemeinek átlaga : {0:0.00}",Atlag);
        }

        private static void Feladat6Gyak()
        {
            Console.WriteLine("Minimum, maximum kiválasztás tétele, és hely");
            int MaxErtek = int.MinValue;
            int MaxHely = 0;
            int MinErtek = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(MaxErtek<Szamok[i])
                {
                    MaxErtek = Szamok[i];
                    MaxHely = i;
                }
                if(MinErtek>Szamok[i])
                {
                    MinErtek = Szamok[i];
                    MinHely = i;
                }
            }
            Console.WriteLine("A legkisebb elem : {0}", MinErtek);
            Console.WriteLine("A legkisebb érték helye : {0}", MinHely);
            Console.WriteLine("A legnyagobb elem : {0}", MaxErtek);
            Console.WriteLine("A legnagyobb érték helye : {0}", MaxHely);
        }

        private static void Feladat5Gyak()
        {
            Console.WriteLine("Bekért elem ellenőrzése");
            int db = 0;
            Console.Write("Kérem adjon egy számot -10 és 50 között amit szeretne keresni: ");
            int Keres = int.Parse(Console.ReadLine());
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]==Keres)
                {
                    db++;
                }
            }
            if(db>0)
            {
                Console.WriteLine("Az Ön által adott szám benne van a tömbben, ennyi alkalommal : {0}", db);
            }
            else
            {
                Console.WriteLine("Az Ön által adott szám nincs benne a tömbben");
            }
        }

        private static void Feladat4Gyak()
        {
            Console.WriteLine("Hány alakalommal volt negatív szám a tömbben");
            int db = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]<0)
                {
                    db++;
                }
            }
            Console.WriteLine("Ennyi alkalommal volt negatív szám az értékek között: {0}",db);
        }

        private static void Feladat3Gyak()
        {
            Console.WriteLine("Elemek kiiratása szamtömbből");
            Console.WriteLine("Elemek kiiratása 12 elem egy sorba");
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(i%12==0)
                { 
                    Console.Write("\n");
                }
                Console.Write("\t{0} , ", Szamok[i]);
            }
        }

        private static void Feladat2Gyak()
        {
            Console.WriteLine("Szam tömb elemekkel való feltöltése");
            /*for (int i = 0; i < Szamok.Length; i++)
            {
                Szamok[i] = rnd.Next(-10, 51);
            }*/
            int j = 0;
            while(j!=Szamok.Length)
            {
                Szamok[j] = rnd.Next(-10, 50);
                j++;
            }
        }

        private static void Futesszezon()
        {
            Feladat1(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat2(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat3(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat4(); Console.WriteLine("\n---------------------------------------------\n");
            Feladat5(); Console.WriteLine("\n---------------------------------------------\n");
        }

        private static void Feladat5()
        {
            Console.WriteLine("Rendezze az adatokat növekvő sorba");
            int CsereKoltseg;
            string CsereHonap;
            for (int i = 0; i < Koltseg.Length-1; i++)
            {
                for (int j = 0; j < Koltseg.Length-1; j++)
                {
                    if(Koltseg[j]>Koltseg[j+1])
                    {
                        CsereKoltseg = Koltseg[j];
                        Koltseg[j] = Koltseg[j + 1];
                        Koltseg[j + 1] = CsereKoltseg;

                        CsereHonap = Honapok[j];
                        Honapok[j] = Honapok[j + 1];
                        Honapok[j + 1] = CsereHonap;
                    }
                }
            }
            Console.WriteLine("Fogyasztás kiiratása");
            for (int i = 0; i < Honapok.Length; i++)
            {
                Console.WriteLine("\t{0,-9} -> {1}", Honapok[i], Koltseg[i]);
            }
        }

        private static void Feladat4()
        {
            Console.WriteLine("Hány alkalommal volt 10'000Ft felett a fűtés díja");
            int Db = 0;
            for (int i = 0; i < Koltseg.Length; i++)
            {
                if(Koltseg[i]>10000)
                {
                    Db++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt a költség 10'000Ft felett: {0}", Db);
        }

        private static void Feladat3()
        {
            Console.WriteLine("Fütésszezon összege, átlaga");
            int Sum = 0;
            double Atlag = 0;
            for (int i = 0; i < Koltseg.Length; i++)
            {
                Sum += Koltseg[i];
                //Sum=Sum+Koltseg[i];
            }
            Atlag = (double)Sum / Koltseg.Length;
            Console.WriteLine("\tA fűtési költség: {0}Ft", Sum);
            Console.WriteLine("\tA fűtési szezon átlag költsége: {0}", Atlag);
        }

        private static void Feladat2()
        {
            Console.WriteLine("Fogyasztás kiiratása");
            for (int i = 0; i < Honapok.Length; i++)
            {
                Console.WriteLine("\t{0,-9} -> {1}", Honapok[i], Koltseg[i]);
            }
        }

        private static void Feladat1()
        {
            Honapok = new string[] { "Oktober", "November", "December", "Január", "Február", "Március", "Április" };
            for (int i = 0; i < Koltseg.Length; i++)
            {
                Koltseg[i] = rnd.Next(2500,12500);
            }
        }
    }
}
