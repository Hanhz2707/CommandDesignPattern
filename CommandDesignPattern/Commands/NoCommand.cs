using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class NoCommand : ICommand
    {
        // Do nothing
        public void Execute()
        {
            Console.WriteLine("This command say nothing");
            Environment.Exit(0);
        }
    }
}
