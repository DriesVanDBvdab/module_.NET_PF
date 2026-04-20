using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    internal interface IKost
    {
        bool Menselijk { get; }
        decimal BerekenKostprijs();
    }
}
