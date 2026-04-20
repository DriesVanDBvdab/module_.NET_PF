using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal interface IKost
    {
        bool Menselijk { get; }
        decimal BerekenKostprijs();
    }
}
