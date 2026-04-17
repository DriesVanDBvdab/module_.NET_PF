using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal abstract partial class Werknemer
    {
        internal class WerkRegime
        {
            public enum RegimeType
            {
                Voltijds, Viervijfde, Halftijds
            }
            public RegimeType Type { get; set; }
            public int AantalVakantiedagen
            {
                get
                {
                    return Type switch
                    {
                        RegimeType.Voltijds => 25,
                        RegimeType.Viervijfde => 20,
                        RegimeType.Halftijds => 12,
                        _ => 0,
                    };
                }
            }
            public WerkRegime(RegimeType type)
            {
                Type = type;
            }
            public override string ToString()
            {
                return Type.ToString();
            }
        }
    }
}
