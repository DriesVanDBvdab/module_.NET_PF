using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal sealed class Manager : Bediende
    {
        public Manager(string naam, DateTime indienst, Geslacht geslacht,
        decimal wedde, decimal bonus, Afdeling afdeling)
        : base(naam, indienst, geslacht, wedde, afdeling)
        {
            Bonus = bonus;
        }
        private decimal bonus;
        public decimal Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                if (value > 0m)
                    bonus = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Bonus: {Bonus}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: {Bonus}";
        }
        public override decimal Premie
        {
            get
            {
                return Bonus * 3m;
            }
        }
    }
}
