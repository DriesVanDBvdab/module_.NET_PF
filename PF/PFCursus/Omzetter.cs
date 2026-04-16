using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Omzetter
    {
        private static readonly double CentimetersPerInch = 2.54; // (1)
        public double CmNaarInch(double cm) // (2)
        {
            return cm / CentimetersPerInch; // (3)
        }
        public double InchNaarCm(double inch)
        {
            return inch * CentimetersPerInch;
        }
    }
}
