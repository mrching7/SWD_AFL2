using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    public class ConcreteTrafficLight : TrafficLight
    {
        private List<Object> objectsCN_;
        private List<Object> objectsCS_;
        private List<Object> objectsCE_;
        private List<Object> objectsCW_;

        private List<Object> objectsPN_;
        private List<Object> objectsPS_;
        private List<Object> objectsPE_;
        private List<Object> objectsPW_;

        public int queueN = 0, QueueS = 0, QueueW = 0, QueueE = 0;

        public ConcreteTrafficLight
        (
            List<ConcreteCar> CarsNorth,
            List<ConcreteCar> CarsSouth,
            List<ConcreteCar> CarsEast,
            List<ConcreteCar> CarsWest,
            List<ConcretePerson> PersonsNorth,
            List<ConcretePerson> PersonsSouth,
            List<ConcretePerson> PersonsEast,
            List<ConcretePerson> PersonsWest
        )
        {
            objectsCN_ = new List<Object>();
            objectsCS_ = new List<Object>();
            objectsCE_ = new List<Object>();
            objectsCW_ = new List<Object>();
            objectsPN_ = new List<Object>();
            objectsPS_ = new List<Object>();
            objectsPE_ = new List<Object>();
            objectsPW_ = new List<Object>();

            objectsCN_.AddRange(CarsNorth);
            objectsCS_.AddRange(CarsSouth);
            objectsCE_.AddRange(CarsEast);
            objectsCW_.AddRange(CarsWest);
            objectsPN_.AddRange(PersonsNorth);
            objectsPS_.AddRange(PersonsSouth);
            objectsPE_.AddRange(PersonsEast);
            objectsPW_.AddRange(PersonsWest);

            foreach (var p in PersonsNorth)
            {
                p.Location = 0;
            }
            foreach (var p in PersonsSouth)
            {
                p.Location = 1;
            }
            foreach (var p in PersonsEast)
            {
                p.Location = 2;
            }
            foreach (var p in PersonsWest)
            {
                p.Location = 3;
            }

            foreach (var p in objectsCN_)
            {
                p.Location = 0;
            }
            foreach (var q in objectsCS_)
            {
                q.Location = 1;
            }
            foreach (var q in objectsCE_)
            {
                q.Location = 2;
            }
            foreach (var q in objectsCW_)
            {
                q.Location = 3;
            }
        }

        public void NotifyForwardNS()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n NORTH / SOUTH ROAD \n");
            Console.ResetColor();

            //STATE 0 = LIGEUD
            //STATE 1 = VENSTRE
            //STATE 2 = HØJRE

            var CarN = objectsCN_.GetEnumerator();
            var CarS = objectsCS_.GetEnumerator();
            var PersonN = objectsPN_.GetEnumerator();
            var PersonS = objectsPS_.GetEnumerator();
            List<Object> CNL = new List<Object>();
            List<Object> CSL = new List<Object>();
            List<Object> CNR = new List<Object>();
            List<Object> CSR = new List<Object>();

            while (CarN.MoveNext() && CarS.MoveNext() && PersonN.MoveNext() && PersonS.MoveNext())
            {
                if (CarN.Current.State == 0)
                {
                    CarN.Current.CrossStreet();
                }
                else if (CarN.Current.State == 1)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car from NORTH tries to turn left must wait for opposite lane to clear and pedestrians to clear");
                    Console.WriteLine("Car from NORTH going left is waiting in line");
                    CNL.Add(CarN.Current);
                    Console.ResetColor();

                }
                else if (CarN.Current.State == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Car from NORTH tries to turn right, must wait for pedestrians to clear the road");
                    Console.WriteLine("Car turning right from NORTH is in line");
                    CNR.Add(CarN.Current);
                    Console.ResetColor();
                }

                //biler fra syd til nord
                if (CarS.Current.State == 0)
                {
                    CarS.Current.CrossStreet();
                }
                else if (CarS.Current.State == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car from SOUTH tries to turn left must wait for opposite lane to clear");
                    Console.WriteLine("Car from SOUTH going left is waiting in line");
                    CSL.Add(CarS.Current);
                    Console.ResetColor();

                }
                else if (CarS.Current.State == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Car from SOUTH tries to turn right, must wait for pedestrians to clear the road");
                    Console.WriteLine("Car turning right from SOUTH is in line");
                    CSR.Add(CarS.Current);
                    Console.ResetColor();
                }

                PersonN.Current.CrossStreet();

                PersonS.Current.CrossStreet();

            }

            foreach (var p in CNR)
            {
                p.CrossStreet();
            }
            foreach (var p in CSR)
            {
                p.CrossStreet();
            }


            foreach (var p in CNL)
            {
                p.CrossStreet();
            }

            foreach (var p in CSL)
            {
                p.CrossStreet();
            }


        }

        public void NotifyForwardEW()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n EAST / WEST ROAD \n");
            Console.ResetColor();

            //STATE 0 = LIGEUD
            //STATE 1 = VENSTRE
            //STATE 2 = HØJRE

            var CarE = objectsCE_.GetEnumerator();
            var CarW = objectsCW_.GetEnumerator();
            var PersonE = objectsPE_.GetEnumerator();
            var PersonW = objectsPW_.GetEnumerator();
            List<Object> CEL = new List<Object>();
            List<Object> CWL = new List<Object>();
            List<Object> CER = new List<Object>();
            List<Object> CWR = new List<Object>();

            while (CarE.MoveNext() && CarW.MoveNext() && PersonE.MoveNext() && PersonW.MoveNext())
            {
                if (CarE.Current.State == 0)
                {
                    CarE.Current.CrossStreet();
                }
                else if (CarE.Current.State == 1)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car from EAST tries to turn left must wait for opposite lane to clear and pedestrians to clear");
                    Console.WriteLine("Car from EAST going left is waiting in line");
                    CEL.Add(CarE.Current);
                    Console.ResetColor();

                }
                else if (CarE.Current.State == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Car from EAST tries to turn right, must wait for pedestrians to clear the road");
                    Console.WriteLine("Car turning right from EAST is in line");
                    CER.Add(CarE.Current);
                    Console.ResetColor();
                }

                //biler fra syd til nord
                if (CarW.Current.State == 0)
                {
                    CarW.Current.CrossStreet();
                }
                else if (CarW.Current.State == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car from WEST tries to turn left must wait for opposite lane to clear");
                    Console.WriteLine("Car from WEST going left is waiting in line");
                    CWL.Add(CarW.Current);
                    Console.ResetColor();

                }
                else if (CarW.Current.State == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Car from WEST tries to turn right, must wait for pedestrians to clear the road");
                    Console.WriteLine("Car turning right from WEST is in line");
                    CWR.Add(CarW.Current);
                    Console.ResetColor();
                }

                PersonE.Current.CrossStreet();

                PersonW.Current.CrossStreet();

            }

            foreach (var p in CER)
            {
                p.CrossStreet();
            }
            foreach (var p in CWR)
            {
                p.CrossStreet();
            }


            foreach (var p in CEL)
            {
                p.CrossStreet();
            }

            foreach (var p in CWL)
            {
                p.CrossStreet();
            }

        }
    }
}