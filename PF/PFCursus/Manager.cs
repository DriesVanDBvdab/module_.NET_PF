using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Manager : Bediende
    {
        public Manager(string naam, DateTime indienst, Geslacht geslacht,
        decimal wedde, decimal bonus)
        : base(naam, indienst, geslacht, wedde)
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
    }
}
