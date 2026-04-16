using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Personenwagen : Voertuig
    {
        public Personenwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, int aantalDeuren)
            : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            AantalDeuren = aantalDeuren;
        }
        const int StandaardAantalDeuren = 4;
        const int StandaardAantalPassagiers = 5;
        private int aantalDeuren = StandaardAantalDeuren;
        public int AantalDeuren
        {
            get { return aantalDeuren; }
            set
            {
                if (value > 0)
                {
                    aantalDeuren = value;
                }
            }
        }

        private int aantalPassagiers = StandaardAantalPassagiers; 
        public int AantalPassagiers 
        { 
            get 
            { 
                return aantalPassagiers; 
            } 
            set 
            { 
                if (value >= 0) 
                    aantalPassagiers = value; 
            } 
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Aantal deuren: {AantalDeuren}");
        }

        public override double GetKyotoScore()
        {
            return (Pk * GemiddeldVerbruik) / AantalPassagiers;
        }
    }
}
