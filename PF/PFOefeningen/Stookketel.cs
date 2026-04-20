using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Stookketel : IVervuiler
    {
        public float CONorm { get; set; }

        public double GeefVervuiling()
        {
            return CONorm * 100;
        }
    }
}
