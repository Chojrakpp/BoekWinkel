// See https://aka.ms/new-console-template for more information
using BoekWinkel;
using System.Security.Cryptography;

delegate void EventHandler(string message);
internal class Program
{

    public static void message(string message)
    {
        Console.WriteLine("---> Bericht" + message);
    }


    private static void Main(string[] args)
    {
        Boek b1 = new Boek();

        char keuze = '0';
        char keuzevp = '0';

        string naam;
        string uitgever;
        double prijs;
        VerschijningsPeriode verschijningsperiode;

        do
        {
            Console.WriteLine("1 Voeg boek toe");
            Console.WriteLine("2 Voeg tijdschrift toe");
            Console.WriteLine("3 Bestel boek of tijdschrift");
            Console.WriteLine("******************************");
            Console.WriteLine("0 Stoppen");
            keuze = Console.ReadLine()[0];
            Console.WriteLine();

            switch (keuze)
            {
                case '0':
                    break;
                case '1':
                    Console.WriteLine("Geef naam van het boek: ");
                    naam = Console.ReadLine();
                    Console.WriteLine("Geef uitgever van het boek: ");
                    uitgever = Console.ReadLine();
                    Console.WriteLine("Geef prijs van het boek (5€ - 50€): ");
                    prijs = Convert.ToDouble(Console.ReadLine());
                    b1 = new Boek(naam, uitgever, prijs);
                    Console.WriteLine("Boek toegevoegd");
                    Console.WriteLine();
                    break;
                case '2':
                    Console.WriteLine("Geef naam van het tijdschrift: ");
                    naam = Console.ReadLine();
                    Console.WriteLine("Geef uitgever van het tijdschrift: ");
                    uitgever = Console.ReadLine();
                    Console.WriteLine("Geef prijs van het tijdschrift (5€ - 50€): ");
                    prijs = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geef verschiningsperiode: ");
                    Console.WriteLine("1 Dagelijks");
                    Console.WriteLine("2 Wekelijks");
                    Console.WriteLine("3 Maandelijks");
                    Console.WriteLine("******************************");
                    Console.WriteLine("0 Stoppen");
                    keuzevp = Console.ReadLine()[0];
                    Console.WriteLine();

                    verschijningsperiode = VerschijningsPeriode.Dagelijks;

                    switch (keuzevp)
                    {
                        case '0':
                            break;
                        case '1':
                            verschijningsperiode = VerschijningsPeriode.Dagelijks;
                            break;
                        case '2':
                            verschijningsperiode = VerschijningsPeriode.Wekelijks;
                            break;
                        case '3':
                            verschijningsperiode = VerschijningsPeriode.Maandelijks;
                            break;

                    }

                    Tijdschrift t1 = new Tijdschrift(naam, uitgever, prijs, verschijningsperiode);
                    Console.WriteLine("Tijdschrift toegevoegd");
                    Console.WriteLine();
                    break;
                case '3':

                    Bestelling<Boek> bestellingboek = new Bestelling<Boek>();
                    Console.WriteLine(bestellingboek.ToString) ;// --------------------------------------- FIX OUTPUT
                    //Tuple<int, int, double> besteling = Boek.Bestel();
                    //Console.WriteLine("Inschrijving: Student " + besteling.Item1 + " is ingeschreven op " + besteling.Item2 + " voor " + besteling.Item3);
                    break;
            }

        } while (keuze != '0');
    }
}