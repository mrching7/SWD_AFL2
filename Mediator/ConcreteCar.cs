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
                    Console.WriteLine("Driving forward from north to south");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from north");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from north");
                }
            }
            else if (location == 1)
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from south to north");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from south");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from south");
                }
            }
            else if (location == 2)
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from West to east");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from west");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from west");
                }
            }
            else
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from east to west");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from east");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from east");
                }
            }
        }
    }
}
