using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class ClassStaticCTOR
    {
        // static CTOR
        public static long ticTack;
        public ClassStaticCTOR()
        {
            ticTack=DateTime.Now.Ticks;
        }
    }
}
