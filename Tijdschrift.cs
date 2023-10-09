using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekWinkel
{
    public enum VerschijningsPeriode
    {
        Dagelijks,
        Wekelijks,
        Maandelijks
    }

    internal class Tijdschrift : Boek
    {
        public VerschijningsPeriode verschijningsperiode;

        public Tijdschrift(string Naam, string Uitgever, double Prijs, VerschijningsPeriode verschijningsperiode)
        {
            Isbn = Volgnummer;
            this.Naam = Naam;
            this.Prijs = Prijs;
            this.Uitgever = Uitgever;
            this.verschijningsperiode = verschijningsperiode;
        }
    }
}
