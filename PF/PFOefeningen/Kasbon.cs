using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Kasbon : ISpaarmiddel
    {
        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intest;
            Eigenaar = eigenaar;
        }
        private DateTime aankoopDatum;
        public DateTime AankoopDatum
        {
            get { return aankoopDatum; }
            set { 
                if(value > new DateTime(1900, 1, 1))
                    aankoopDatum = value; 
            }
        }
        private decimal bedrag;
        public decimal Bedrag
        {
            get { return bedrag; }
            set {
                if (value > 0)
                    bedrag = value;
            }
        }
        private int looptijd;
        public int Looptijd
        {
            get { return looptijd; }
            set {
                if (value > 0)
                    looptijd = value;
            }
        }
        private decimal intest;
        public decimal Intrest
        {
            get { return intest; }
            set {
                if (value > 0)
                    intest = value;
            }
        }
        public Klant Eigenaar { get; set; }
        public void Afbeelden()
        {
            Console.WriteLine($"Kasbon van {Bedrag} euro.");
            Console.WriteLine($"Gekocht op {AankoopDatum.ToShortDateString()}.");
            Console.WriteLine($"Looptijd van {Looptijd} jaren.");
            Console.WriteLine($"Intrest van {Intrest}%.");
            Console.WriteLine($"Eigenaar {Eigenaar.Voornaam} {Eigenaar.Achternaam}");
        }
    }
}
