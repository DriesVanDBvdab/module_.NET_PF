using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class LijnenTrekker
    {
        public void TrekLijn(int lengte, char teken = '-') // (1)
        {
            for (int i = 0; i < lengte; i++)
            {
                Console.Write(teken);
            }
            Console.WriteLine();
        }
        public void TrekLijn(int lengte) // (2)
        {
            TrekLijn(lengte, '-'); // (3)
        }
        public void TrekLijn() // (4)
        {
            TrekLijn(79); // (5)
        }
    }
}
