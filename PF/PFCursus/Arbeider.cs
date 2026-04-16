using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Arbeider : Werknemer
    {
        public Arbeider(string naam, DateTime inDienst, Geslacht geslacht,
            decimal uurloon, byte ploegenstelsel)
            : base(naam, inDienst, geslacht)
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
                if (value >= 0m)
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
                    ploegenstelsel = value;
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
    }
}
