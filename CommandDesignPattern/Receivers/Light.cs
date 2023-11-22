using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Receivers
{
    public class Light
    {
        public bool On { get; set; } 

        public Light() { On = false; }

        public void TurningOn()
        {
            On = true;
            Console.WriteLine("Turning on Light!!!");
        }
        public void TurningOff()
        {
            On = false;
            Console.WriteLine("Turning off Light!!!");
        }
    }
}
