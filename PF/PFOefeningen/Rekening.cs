using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal abstract class Rekening : ISpaarmiddel
    {
        public Rekening(string rekeningNummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        {
            RekeningNummer = rekeningNummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }

        readonly DateTime vroegsteDatum = new DateTime(1900, 1, 1);
        private string rekeningNummer = string.Empty;
        public string RekeningNummer
        {
            get { return rekeningNummer; }
            set
            {
                if (value.Length == 16 && 
                    value.StartsWith("BE") &&
                    int.TryParse(value.Substring(2,2), out _) &&
                    long.TryParse(value.Substring(4, 10), out long  rekeningTussenNummer) &&
                    long.TryParse(value.Substring(14, 2), out long controleNummer) &&
                    rekeningTussenNummer %97 == controleNummer)
                {
                    rekeningNummer = value;
                }
            }
        }
        private decimal saldo = 0;
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value;  }
        }
        DateTime creatieDatum = DateTime.Now;
        public DateTime CreatieDatum
        {
            get { return creatieDatum; }
            set
            {
                if (value > vroegsteDatum)
                {
                    creatieDatum = value;
                }
            }
        }
        public Klant eigenaar;
        public Klant Eigenaar 
        { 
            get{ return eigenaar; } 
            set { eigenaar = value; } 
        }
        public void Afhalen(decimal bedrag)
        {
            if (bedrag > 0)
            {
                saldo -= bedrag;
            }
        }
        public void Storten(decimal bedrag)
        {
            if (bedrag > 0)
            {
                saldo += bedrag;
            }
        }
        public virtual void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {rekeningNummer}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Creatiedatum: {creatieDatum}");
            eigenaar.Afbeelden();
        }

    }
}
