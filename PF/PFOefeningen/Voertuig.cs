using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal abstract class Voertuig : IVervuiler, IPrivaat, IMilieu
    {
        public Voertuig()
        {
        }
        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            Polishouder = polishouder;
            Kostprijs = kostprijs;
            Pk = pk;
            GemiddeldVerbruik = gemiddeldVerbruik;
            Nummerplaat = nummerplaat;
        }
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

        public virtual void Afbeelden()
        {
            Console.WriteLine($"Polishouder: {polishouder}");
            Console.WriteLine($"Kostprijs: {kostprijs}");
            Console.WriteLine($"PK: {pk}");
            Console.WriteLine($"Gemiddeld verbruik: {gemiddeldVerbruik}");
            Console.WriteLine($"Nummerplaat: {nummerplaat}");
        }
        public abstract double GetKyotoScore();

        public abstract double GeefVervuiling();

        public string GeefPrivateData()
        {
            return $"Polishouder: {Polishouder}.\nNummerplaat: {Nummerplaat}.";
        }

        public string GeefMilieuData()
        {
            return $"PK: {Pk}.\nKostprijs: {Kostprijs}.\nGemiddeld verbruik: {GemiddeldVerbruik}";
        }
    }
}
