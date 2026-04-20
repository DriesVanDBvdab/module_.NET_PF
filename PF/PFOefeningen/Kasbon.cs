using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Kasbon : ISpaarmiddel
    {
        internal class AankoopDatumException : Exception
        {
            public DateTime VerkeerdeAankoopDatum { get; set; }
            public AankoopDatumException(string message, DateTime verkeerdeAankoopDatum)
                : base(message)
            {
                VerkeerdeAankoopDatum = verkeerdeAankoopDatum;
            }
        }
        internal class LooptijdException : Exception
        {
            public int VerkeerdeLooptijd { get; set; }
            public LooptijdException(string message, int verkeerdeLooptijd)
                : base(message)
            {
                VerkeerdeLooptijd = verkeerdeLooptijd;
            }
        }
        internal class BedragException : Exception
        {
            public decimal VerkeerdBedrag { get; set; }
            public BedragException(string message, decimal verkeerdBedrag)
                : base(message)
            {
                VerkeerdBedrag = verkeerdBedrag;
            }
        }
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
                else
                    throw new AankoopDatumException("Aankoopdatum moet na 1/1/1900 zijn!", value);
            }
        }
        private decimal bedrag;
        public decimal Bedrag
        {
            get { return bedrag; }
            set {
                if (value > 0)
                    bedrag = value;
                else
                    throw new BedragException("Bedrag moet positief zijn!", value);
            }
        }
        private int looptijd;
        public int Looptijd
        {
            get { return looptijd; }
            set {
                if (value > 0)
                    looptijd = value;
                else
                    throw new LooptijdException("Looptijd moet positief zijn!", value);
            }
        }
        private decimal intest;
        public decimal Intrest
        {
            get { return intest; }
            set {
                if (value > 0)
                    intest = value;
                else
                    throw new IntrestException("Intrest moet positief zijn!", value);
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
