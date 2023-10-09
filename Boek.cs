using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekWinkel
{

    internal class Boek
    {
        public static int Volgnummer // id uniek
        {
            get{
                id++; return id;} 
            set{
                id = value;}
        }
        public int Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        public double Prijs
        {
            get {
                return prijs; }
            set {
                try
                {
                    if (value < 50.00 && value > 5.00)
                    { prijs = value; }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex + "ERROR, geef een prijs tussen 5€ en 50€"); // ---------------------------> FIX TRY CATCH
                }
            }
        }

        private static int id;
        private static double prijs;

        public Boek()
        {
            Isbn = Volgnummer; // isbn uniek
        }

        public Boek(string Naam, string Uitgever, double Prijs)
        {
            Isbn = Volgnummer;
            this.Naam = Naam;
            this.Prijs = Prijs;
            this.Uitgever = Uitgever;
        }

        public void Lees(string Naam)
        {
            Console.WriteLine("Het boek: " + Naam + "; is gelezen");
        }

        public override string ToString()
        {
            return "isbn: " + Isbn + "; Naam: " + Naam + "; Uitgever: " + Uitgever + "; Prijs: " + Prijs;
        }
    }
}
