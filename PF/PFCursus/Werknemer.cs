using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Werknemer
    {
        private string naam = string.Empty; // (2)
        public string Naam // (3)
        {
            get // (4)
            {
                return naam;
            }
            set // (5)
            {
                if (value != string.Empty)
                    naam = value;
            }
        }
        private DateTime inDienst;
        public DateTime InDienst 
        { 
            get { return inDienst; } 
            set { inDienst = value; } 
        }
        private Geslacht geslacht; public Geslacht Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }
    }
}
