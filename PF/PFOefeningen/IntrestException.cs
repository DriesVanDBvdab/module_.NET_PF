using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class IntrestException : Exception
    {
        public decimal VerkeerdeIntrest { get; set; }
        public IntrestException(string message, decimal verkeerdeIntrest)
            : base(message)
        {
            VerkeerdeIntrest = verkeerdeIntrest;
        }
    }
}
