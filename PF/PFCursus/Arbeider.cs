using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    internal class Arbeider : Werknemer
    {
        internal class UurloonException : Exception // (1)
        {
            public decimal VerkeerdUurloon { get; set; } // (2)
            public UurloonException(string message,
            decimal verkeerdUurloon) // (3)
            : base(message) // (4)
            {
                VerkeerdUurloon = verkeerdUurloon;
            }
        }
        internal class PloegenstelselException : Exception
        {
            public byte VerkeerdPloegenstelsel { get; set; }
            public PloegenstelselException(string message,
            byte verkeerdPloegenstelsel)
            : base(message)
            {
                VerkeerdPloegenstelsel = verkeerdPloegenstelsel;
            }
        }
        public Arbeider(string naam, DateTime inDienst, Geslacht geslacht,
            decimal uurloon, byte ploegenstelsel)
            : base(naam, inDienst, geslacht)
        {
            Uurloon = uurloon;
            Ploegenstelsel = ploegenstelsel;
        }
        public Arbeider(string naam, DateTime inDienst, Geslacht geslacht,
            decimal uurloon, byte ploegenstelsel, Afdeling afdeling)
            : base(naam, inDienst, geslacht, afdeling)
        {
            Uurloon = uurloon;
            Ploegenstelsel = ploegenstelsel;
        }
        private decimal uurloon;
        public decimal Uurloon
        {
            get { return uurloon; }
            set
            {
                if (value <= 0)
                    throw new UurloonException("Uurloon<=0!", value); // (5)
                uurloon = value;
            }
        }
        private byte ploegenstelsel;
        public byte Ploegenstelsel
        {
            get { return ploegenstelsel; }
            set
            {
                if (value >= 1 && value <= 3)
                    throw new PloegenstelselException("Verkeerd ploegenstelsel", value); // (6)
                ploegenstelsel = value;
            }
        }
        public override decimal Premie
        {
            get
            {
                return Uurloon * 150m;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Uurloon: {Uurloon}"); 
            Console.WriteLine($"Ploegenstelsel: {Ploegenstelsel}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Uurloon} euro/uur";
        }

        public override decimal BerekenKostprijs()
        {
            return Uurloon * 2000m;
        }
    }
}
