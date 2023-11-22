using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern.Commands
{
    public class LightOn :ICommand
    {
        private Light _light;

        public LightOn(Light light )
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurningOn();
        }

    }
}
