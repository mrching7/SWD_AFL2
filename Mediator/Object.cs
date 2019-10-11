using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract  class Object
    {
        public abstract void CrossStreet();

        public abstract int Location { get; }

        public abstract int State { get; }

        #region slet
        //public enum Currentstate
        //{
        //    Driveforward,
        //    Driveright,
        //    Driveleft
        //};
        //public enum CurrentLocation
        //{
        //    North=0,
        //    South=1,
        //    West=2,
        //    East=3
        //};
        #endregion
    }


    public class ConcretePerson : Object
    {
        private int location;
        private int state;
        public ConcretePerson()
        {
            Random rnd = new Random();
            location = rnd.Next(4);
            state=0;
        }
        public override  int Location
        {
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
            else if (location==1 && state == 0)
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

    public class ConcreteCar : Object
    {

        private int state;
        private int location;

        public override int State
        {
            get{ return state; }
             
        }
        public override int Location 
        {
            get { return location; }
        }
        public ConcreteCar()
        {
            Random rnd= new Random();

            state = rnd.Next(3);

            location = rnd.Next(4);

           
        }

        public override void CrossStreet()
        {
            if (location==0)
            {
                if (state==0)
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
            else if (location==1)
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
