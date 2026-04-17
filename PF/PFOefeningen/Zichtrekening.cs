using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningNummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet, Klant eigenaar)
            : base(rekeningNummer, saldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }
        private decimal maxKrediet;
        public decimal MaxKrediet
        {
            get
            {
                return maxKrediet;
            }
            set
            {
                if (value < 0)
                    maxKrediet = value;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Max Krediet: {MaxKrediet}");
        }
    }
}
