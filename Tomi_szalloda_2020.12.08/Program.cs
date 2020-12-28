using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tomi_szalloda_2020._12._08
{
    class Program
    {
        struct Adat
        {
            public int foglalassorszam;
            public int szobaszam;
            public int erkezesnap;
            public int tavozasnap;
            public int vendegszam;
            public int reggeli;
            public string azonosito;
        }
        static void Main(string[] args)
        {
            //1
            Adat[] adatok = new Adat[1000];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\pitypang.txt");
            int n = 0;
            int elsosor = int.Parse(olvas.ReadLine());
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                string[] db = sor.Split();
                adatok[n].foglalassorszam = int.Parse(db[0]);
                adatok[n].szobaszam = int.Parse(db[1]);
                adatok[n].erkezesnap = int.Parse(db[2]);
                adatok[n].tavozasnap = int.Parse(db[3]);
                adatok[n].vendegszam = int.Parse(db[4]);
                adatok[n].reggeli = int.Parse(db[5]);
                adatok[n].azonosito = db[6];
                n++;
            }
            olvas.Close();
            //2
            int max = 0;
            int segit = 0;
            for (int i =0;i<n;i++)
            {
                if (adatok[i].tavozasnap-adatok[i].erkezesnap>max)
                {
                    max = adatok[i].tavozasnap - adatok[i].erkezesnap;
                    segit = i;
                }
            }
            Console.WriteLine("2.Feladat:\n"+adatok[segit].azonosito + " (" + adatok[segit].erkezesnap + ") - " + max);
            //3
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\Downloads\bevetel.txt");
            int osszeg = 0;
            for (int i =0; i<n;i++)
            {
                osszeg = 0;
                if (adatok[i].erkezesnap < 121)
                {
                    if (adatok[i].vendegszam<3)
                    {
                        if (adatok[i].reggeli==0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 9000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" +osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 9000) + ((adatok[i].tavozasnap - adatok[i].erkezesnap)*adatok[i].vendegszam*1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" +osszeg);
                        }
                    }
                    else
                    {
                        if (adatok[i].reggeli == 0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 9000+ (adatok[i].tavozasnap - adatok[i].erkezesnap)*2000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 9000) + (adatok[i].tavozasnap - adatok[i].erkezesnap) * 2000+(adatok[i].vendegszam * 1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                    }
                }
                else if ( adatok[i].erkezesnap < 244)
                {
                    if (adatok[i].vendegszam < 3)
                    {
                        if (adatok[i].reggeli == 0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 10000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 10000) + ((adatok[i].tavozasnap - adatok[i].erkezesnap)*adatok[i].vendegszam * 1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                    }
                    else
                    {
                        if (adatok[i].reggeli == 0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 10000 + (adatok[i].tavozasnap - adatok[i].erkezesnap) * 2000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 10000) + (adatok[i].tavozasnap - adatok[i].erkezesnap) * 2000 + ((adatok[i].tavozasnap - adatok[i].erkezesnap)*adatok[i].vendegszam * 1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                    }
                }
                else
                {
                    if (adatok[i].vendegszam < 3)
                    {
                        if (adatok[i].reggeli == 0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 8000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 8000) + ((adatok[i].tavozasnap - adatok[i].erkezesnap)*adatok[i].vendegszam * 1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                    }
                    else
                    {
                        if (adatok[i].reggeli == 0)
                        {
                            osszeg = (adatok[i].tavozasnap - adatok[i].erkezesnap) * 8000 + (adatok[i].tavozasnap - adatok[i].erkezesnap) * 2000;
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                        else
                        {
                            osszeg = ((adatok[i].tavozasnap - adatok[i].erkezesnap) * 8000) + (adatok[i].tavozasnap - adatok[i].erkezesnap) * 2000 + ((adatok[i].tavozasnap - adatok[i].erkezesnap)*adatok[i].vendegszam * 1100);
                            ir.WriteLine(adatok[i].foglalassorszam + ":" + osszeg);
                        }
                    }
                }
            }
            ir.Close();

            //4
            Console.WriteLine("4.feladat");
            int[] napok = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
            int ejszakak_szama = 0;
            for (int i = 0; i < napok.Length - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adatok[j].erkezesnap > napok[i] && adatok[j].erkezesnap <= napok[i + 1])
                    {
                        int eltoltott_napok = adatok[j].tavozasnap - adatok[j].erkezesnap;
                        ejszakak_szama += eltoltott_napok * adatok[j].vendegszam;
                    }
                }
                Console.WriteLine($"{i + 1}: {ejszakak_szama} vendégéj");
                ejszakak_szama = 0;
            }

            //5
            Console.Write("Kérem adja meg a kezdő dátumhoz tartozó nap sorszámát: ");
            int erkezesnap = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az eltöltendő napok számát: ");
            int eltoltendonapok = int.Parse(Console.ReadLine());
            int[] foglalt_szobaszam = new int[27];
            int szoba_szama = 27;
            for (int i =0;i<foglalt_szobaszam.Length;i++)
            {
                foglalt_szobaszam[i] = i + 1;
            }
            
            foreach (var i in adatok)
            {
                if (i.tavozasnap >= erkezesnap && i.erkezesnap <= erkezesnap + eltoltendonapok)
                {                 
                    if (foglalt_szobaszam[i.szobaszam - 1] != 0)
                    {
                        foglalt_szobaszam[i.szobaszam - 1] = 0;
                        szoba_szama--;
                    }                 
                }
            }
            for (int i = 0;i<foglalt_szobaszam.Length;i++)
            {
                if (foglalt_szobaszam[i] != 0)
                {
                  
                    Console.Write($"{foglalt_szobaszam[i]} ");
                    
                }
            }
            Console.WriteLine($"\n{szoba_szama}");
            Console.ReadKey();

        }
    }
}
