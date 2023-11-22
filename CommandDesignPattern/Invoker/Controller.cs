using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDesignPattern.Commands;

namespace CommandDesignPattern.Invoker
{
    public class Controller
    {
        private List<ICommand> Commands = new List<ICommand>(5);

        public Controller()
        {
            for (int i = 0; i < Commands.Capacity; i++)
            {
                Commands.Add(new NoCommand());
            }
        }
        public void SetCommandAtSlot(int slot, ICommand command)
        {
            Commands[slot] = command;
        }

        // Call this method when a button on the remote controller is pressed
        public void OnButtonPressed(int slot)
        {
            Commands[slot].Execute();
        }


    }
}
