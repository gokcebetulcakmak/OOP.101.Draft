using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    //constructor overloading
    internal class ClassHomeOL
    {
        public ClassHomeOL() // parametresiz standar bir ctor
        {
            Console.WriteLine( "Ev {0} adresinde, {1} kapı numarasında bulunuyor..",StreetName, DoorNumber);
        }
        public ClassHomeOL(int dn) // 1 parametreli bir ctor
        {
            DoorNumber= dn; // gelen parametreyi direkt property e atadım.
            Console.WriteLine("Ev {0} adresinde, {1} kapı numarasında bulunuyor..", StreetName, DoorNumber);
        }
        public ClassHomeOL(int dn, string sn)
        {
            DoorNumber = dn; // gelen parametreyi direkt property e atadım.
            StreetName= sn; // gelen sn parametresi ilgili yere aktarılıyor.
            Console.WriteLine("Ev {0} adresinde, {1} kapı numarasında bulunuyor..", StreetName, DoorNumber);
        }


        public int DoorNumber { get; set; } = 111;
        public string StreetName { get; set; } = "One Redmond Way..";

    }
}
