using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekWinkel
{
    internal class Bestelling<T>
    {
        public event EventHandler BestellingEvent; // trigger een event met eenvoudige boodschap met confirm

        void AlsBestelling(string message)
        {
            if (BestellingEvent != null)
            {
                BestellingEvent("---> bericht" + message);
            }
        }

        private static int id;
        public int Id //id uniek
        {  
            get { 
                id++; return id; } 
            set { 
                id = value;
            }
        }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public VerschijningsPeriode Abonement { get; set; }

        public static void message(string message)
        {
            Console.WriteLine(message);
        }

        public Bestelling()
        {
            BestellingEvent += message;
        }

        public override string ToString()
        {
            AlsBestelling("Bestelling gemaakt!");
            return "id: " + id + "; Naam: " + Item + "; Aantal: " + Aantal + "; Abonament: " + Abonement;
        }

        //internal Bestelgegevens Inschrijving()
        //{
        //    return new Bestelgegevens()
        //    {
        //        Isbn = Isbn,
        //        Prijs = prijs,
        //    };
        //}

        //internal Tuple<int, int, double> Bestel()
        //{
        //    Console.WriteLine("Hoeveel boeken wilt u aankopen?"); // return isbn van het boek, aantal bestelde exemplaren en totale prijs.
        //    Aantal = Convert.ToInt32(Console.ReadLine());

        //    Tuple.Create()
        //    return retour ;
        //}

        //internal struct Bestelgegevens
        //{
        //    internal int Isbn;
        //    internal int Prijs;
        //}

    }
}
