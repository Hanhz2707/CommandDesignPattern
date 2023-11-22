
using CommandDesignPattern.Commands;
using CommandDesignPattern.Invoker;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Light light = new Light();
            Thermorstat thermorstat = new Thermorstat();

            Controller controller = new Controller();   

            LightOn lightOn = new LightOn(light);
            LightOff lightOff = new LightOff(light);
            ThermorstatDecreasing thermorstatDecreasing = new ThermorstatDecreasing(thermorstat);
            ThermorstatIncreasing thermorstatIncreasing = new ThermorstatIncreasing(thermorstat);
            NoCommand noCommand = new NoCommand();

            controller.SetCommandAtSlot(0, lightOff);
            controller.SetCommandAtSlot(1, lightOn);
            controller.SetCommandAtSlot(2, thermorstatIncreasing);
            controller.SetCommandAtSlot(3, thermorstatDecreasing);
            controller.SetCommandAtSlot(4, noCommand);

            Console.WriteLine("WELCOME TO  IOT Project\n" +
                  "Press 0 to turn off the light\n" +
                  "Press 1 to turn on the light\n" +
                  "Press 2 to increase thermostat's temperature\n" +
                  "Press 3 to decrease thermostat's temperatur\n" +
                  "Press 4 to no command");


            while (true)
            {
                Console.Write("\nYou press: ");

                // Check if the input is an integer
                int slot;
                if (!int.TryParse(Console.ReadLine(), out slot))
                {
                    // If not, try again
                    Console.WriteLine("Invalid input. Try again");
                    continue;
                }

                // Check if the input is in the controller's range
                try
                {
                    controller.OnButtonPressed(slot); 
                }
                catch (ArgumentOutOfRangeException)
                {
                   
                    Console.WriteLine("The remote controller only has 4 buttons, which means 4 is the max you can get. Try again");
                }
            }
        }
    }
}
    

