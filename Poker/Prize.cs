using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    /// <summary>
    /// Prize class used to enumerate prize list.
    /// </summary>
    public class Prize
    {
        public string Name { get; set; }
        public int Multiplier { get; set; }
        public Prize() { }
    }
}
