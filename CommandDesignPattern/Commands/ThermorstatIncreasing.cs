using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern.Commands
{
    public class ThermorstatIncreasing : ICommand
    {
        private Thermorstat _thermorstat;

        public ThermorstatIncreasing (Thermorstat thermorstat)
        {
               _thermorstat = thermorstat;
        }
         public void Execute ()
         {
            _thermorstat.Increasing();
         }
    }
}
