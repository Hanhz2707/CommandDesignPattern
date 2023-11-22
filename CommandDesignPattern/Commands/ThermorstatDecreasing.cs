using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern.Commands
{
    public class ThermorstatDecreasing : ICommand
    {
        private Thermorstat _thermorstat;

        public ThermorstatDecreasing(Thermorstat thermorstat)
        {
            _thermorstat = thermorstat;
        }
        public void Execute()
        {
            _thermorstat.Decreasing();
        }
    }
}
