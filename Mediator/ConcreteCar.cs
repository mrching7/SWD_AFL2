using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    public class ConcreteCar : Object
    {

        private int state;
        private int location;

        public override int State
        {
            get { return state; }

        }
        public override int Location
        {
            set { location = value; }
            get { return location; }
        }

        public ConcreteCar()
        {
            Random rnd = new Random();
            state = rnd.Next(3);
        }

        public override void CrossStreet()
        {
            if (location == 0)
            {
                if (state == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Driving forward from NORTH to SOUTH");
                    Console.ResetColor();
                }
                else if (state == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Turning left from NORTH");
                    Console.ResetColor();
                }
                else if (state == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("turning right from NORTH");
                    Console.ResetColor();
                }
            }
            else if (location == 1)
            {
                if (state == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Driving forward from SOUTH to NORTH");
                    Console.ResetColor();
                }
                else if (state == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Turning left from SOUTH");
                    Console.ResetColor();
                }
                else if (state == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("turning right from SOUTH");
                    Console.ResetColor();
                }
            }
            else if (location == 2)
            {
                if (state == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Driving forward from WEST to EAST");
                    Console.ResetColor();
                }
                else if (state == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Turning left from WEST");
                    Console.ResetColor();
                }
                else if (state == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("turning right from WEST");
                    Console.ResetColor();
                }
            }
            else
            {
                if (state == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Driving forward from east to west");
                    Console.ResetColor();
                }
                else if (state == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Turning left from EAST");
                    Console.ResetColor();
                }
                else if (state == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("turning right from EAST");
                    Console.ResetColor();
                }
            }
        }
    }
}
