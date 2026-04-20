using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Bediende : Werknemer
    {
        public Bediende(string naam, DateTime indienst,
        Geslacht geslacht, decimal wedde, Afdeling afdeling)
        : base(naam, indienst, geslacht, afdeling)
        {
            Wedde = wedde;
        }

        private decimal wedde;
        public decimal Wedde
        {
            get { return wedde; }
            set
            {
                if (value >= 0m)
                    wedde = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden(); Console.WriteLine($"Wedde: {Wedde}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Wedde} euro/maand";
        }
        public override decimal Premie
        {
            get
            {
                return Wedde * 2m;
            }
        }
        public override decimal BerekenKostprijs()
        {
            return Wedde * 12m;
        }
    }
}
