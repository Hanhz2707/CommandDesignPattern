using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern.Commands
{
    public class LightOff : ICommand
    {
        private Light _light;

        public LightOff(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurningOff();
        }
    }
}
