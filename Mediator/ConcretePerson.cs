using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcretePerson : Object
    {
        private int location;
        private int state;
        public ConcretePerson()
        {
            Random rnd = new Random();
            location = rnd.Next(4);
            state = 0;
        }
        public override int Location
        {
            set { location = value; }
            get { return location; }
        }
        public override int State
        {
            get { return state; }
        }
        public override void CrossStreet()
        {
            if (location == 0 && state == 0)
            {
                Console.WriteLine("Pedestrian crossing the street from north west to south");
            }
            else if (location == 1 && state == 0)
            {
                Console.WriteLine("Pedestrian crossing the street from south east to north");
            }
            else if (location == 2 && state == 0)
            {
                Console.WriteLine("Pedestrian crossing the street from south west to east");
            }
            else if (location == 3 && state == 0)
            {
                Console.WriteLine("Pedestrian crossing the street from north east to west");
            }
        }

    }
}
