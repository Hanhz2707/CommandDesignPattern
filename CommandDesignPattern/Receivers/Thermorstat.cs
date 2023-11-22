using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Receivers
{
    public class Thermorstat
    {
        public int Temp { get; set; }
        public Thermorstat(int temp)
        {
            Temp = temp;
        }
        public Thermorstat()
        {
            Temp = 20;
        }

        public void Increasing()
        {
            Temp++;
            Console.WriteLine("Current Temperature: " + Temp + " Celcius");
        }

        public void Decreasing()
        {
            Temp--;
            Console.WriteLine("Current Temperature: " + Temp + " Celcius");
        }
    }
}
