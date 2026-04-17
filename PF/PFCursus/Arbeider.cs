using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Arbeider : Werknemer
    {
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
    }
}
