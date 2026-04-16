using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Rekening
    {
        readonly DateTime vroegsteDatum = new DateTime(1900, 1, 1);
        private string rekeningNummer = string.Empty;
        public string RekeningNummer
        {
            get { return rekeningNummer; }
            set
            {
                if (value.Length == 16 && value.StartsWith("BE"))
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
        public  void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {rekeningNummer}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Creatiedatum: {creatieDatum}");
        }

    }
}
