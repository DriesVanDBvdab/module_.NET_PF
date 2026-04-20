using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Zichtrekening : Rekening
    {
        internal class MaxKredietException : Exception
        {
            public decimal VerkeerdMaxKrediet { get; set; }
            public MaxKredietException(string message, decimal verkeerdMaxKrediet)
                : base(message)
            {
                VerkeerdMaxKrediet = verkeerdMaxKrediet;
            }
        }
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
                else
                    throw new MaxKredietException("Max krediet moet negatief zijn!", value);
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Max Krediet: {MaxKrediet}");
        }
    }
}
