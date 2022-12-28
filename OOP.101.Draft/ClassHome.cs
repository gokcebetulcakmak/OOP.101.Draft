using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class ClassHome
    {
        // evlerle ilgili bir örnek class
        public ClassHome(int param )
        {
            DoorNumber= param; //Parametreden gelen değeri property alanına yüklüyorum.
            Console.WriteLine("Ev {0} adresinde, {1} kapı numarasında bulunuyor..", StreetName, DoorNumber);
        }

        public int DoorNumber { get; set; }
        public string StreetName { get; set; } = "Downing Street..";
    }
}
