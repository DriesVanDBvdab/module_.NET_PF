using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Vrachtwagen : Voertuig
    {
        const float standaardMaximumLading = 10000f;
        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat , float maximumLading)
            : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            this.maximumLading = maximumLading;
        }
        private float maximumLading = standaardMaximumLading;
        public float MaximumLading
        {
            get
            {
                return maximumLading;
            }
            set
            {
                if (value > 0)
                {
                    maximumLading = value;
                }
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Maximum lading: {MaximumLading} kg");
        }
    }
}
