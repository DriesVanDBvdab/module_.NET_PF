using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Voertuig
    {
        private string polishouder = "onbepaald";
        public string Polishouder
        {
            get { return polishouder; }
            set { polishouder = value; }
        }
        private decimal kostprijs = 0;
        public decimal Kostprijs
        {
            get { return kostprijs; }
            set
            {
                if (value > 0)
                {
                    kostprijs = value;
                }
            }
        }
        private int pk = 0;
        public int Pk
        {
            get { return pk; }
            set
            {
                if (value > 0)
                {
                    pk = value;
                }
            }
        }
        private float gemiddeldVerbruik = 0;
        public float GemiddeldVerbruik
        {
            get { return gemiddeldVerbruik; }
            set
            {
                if (value > 0)
                {
                    gemiddeldVerbruik = value;
                }
            }
        }
        private string nummerplaat = "onbepaald";
        public string Nummerplaat
        {
            get { return nummerplaat; }
            set { nummerplaat = value; }
        }

        public void Afbeelden()
        {
            Console.WriteLine($"Polishouder: {polishouder}");
            Console.WriteLine($"Kostprijs: {kostprijs}");
            Console.WriteLine($"PK: {pk}");
            Console.WriteLine($"Gemiddeld verbruik: {gemiddeldVerbruik}");
            Console.WriteLine($"Nummerplaat: {nummerplaat}");
        }
    }
}
