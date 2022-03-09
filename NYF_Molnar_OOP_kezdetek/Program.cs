using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYF_Molnar_OOP_kezdetek
{
    class Program
    {
        // Tegyük fel, hogy egy fájlban ilyen adatok vannak kutyákról (név, marmagasság, életkor, fajta):

        /*
         Blöki  40.5  3 Puli
         Bodri  50.32   4   Komondor
         Xerxész    120.5  5    Dán dog
         János  24.2    6   Csivava
         */

        // A konstruktorok arra valók, hogy megszabja az ember,
        // hogy hogyan lehessen kutya objektumokat létrehozni.


        // a múltkor tanultunk olyat, hogy 
        class Kutya
        {
            public string név;
            public double marmagasság;
            public int kor;
            public string fajta;

            public Kutya()
            {
                Console.WriteLine("Kutya vagyok, megszülettem.");
            }

            public Kutya(string név, double marmagasság, int kor, string fajta)
            {
                this.név = név;
                this.marmagasság = marmagasság;
                this.kor = kor;
                this.fajta = fajta;
            }

            public Kutya(string[] sortömb)
            {
                this.név = sortömb[0];
                this.marmagasság = double.Parse(sortömb[1]);
                this.kor = int.Parse(sortömb[2]);
                this.fajta = sortömb[3];
            }

            public void Bemutatkozik()
            {
                Console.WriteLine($"{név} vagyok, egy {kor} éves {fajta}. Marmagasságom {marmagasság}.");
            }
            public void Ugat()
            {
                Console.WriteLine($"Vau.");
            }
        }

        static void Main(string[] args)
        {
            {
                Kutya andrás = new Kutya();
                andrás.név = "András";
                andrás.kor = 9;
                andrás.marmagasság = 70.3;
                andrás.fajta = "Border collie";

                andrás.Bemutatkozik();
                andrás.Ugat();
            }
            {
                Kutya Nikolausz = new Kutya("Nikolausz", 100.2, 13, "Vizsla");
            }



            List<Kutya> kutyák = new List<Kutya>();
            string[] sorok = File.ReadAllLines("input.txt", Encoding.Default);

            foreach (string sor in sorok)
            {
                string[] sortömb = sor.Split('\t');
                Kutya k = new Kutya(sortömb);
                kutyák.Add(k);
            }
        }
    }
}
