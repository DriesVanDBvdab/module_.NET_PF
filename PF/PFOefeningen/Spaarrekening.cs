using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Spaarrekening : Rekening
    {
        public Spaarrekening(string rekeningNummer, decimal saldo, DateTime creatieDatum, decimal intrest)
            : base(rekeningNummer, saldo, creatieDatum)
        {
            Intrest = intrest;
        }

        private decimal intrest;
        public decimal Intrest
        {
            get
            {
                return intrest;
            }
            set
            {
                if (value >= 0)
                    intrest = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Intrest: {Intrest}%");
        }
    }
}
