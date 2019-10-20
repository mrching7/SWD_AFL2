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
            objectsCN_.AddRange(CarsNorth);
            objectsCS_.AddRange(CarsSouth);
            objectsCE_.AddRange(CarsEast);
            objectsCW_.AddRange(CarsWest);

            objectsPN_.AddRange(PersonsNorth);
            objectsPS_.AddRange(PersonsSouth);
            objectsPE_.AddRange(PersonsEast);
            objectsPW_.AddRange(PersonsWest);

            foreach (var p in objectsCN_)
            {
                p.Location = 0;
            }
            foreach (var q in objectsCS_)
            {
                q.Location = 0;
            }


        }

        public void NotifyForwardNS()
        {

            //STATE 0 = FORWARD
            //STATE 1 = VENSTRE
            //STATE 2 = HØJRE

            var CarN = objectsCN_.GetEnumerator();
            var CarS = objectsCS_.GetEnumerator();

            while (CarN.MoveNext() && CarS.MoveNext())
            {
                if (CarN.Current.State == 0)
                {
                    CarN.Current.CrossStreet();
                }
                else if (CarN.Current.State == 1)
                {
                    if (CarS.Current == null)
                    {
                        CarN.Current.CrossStreet();
                        Console.WriteLine("CarS is NULL");
                    }
                }
                else if (CarN.Current.State == 2)
                {
                    CarN.Current.CrossStreet();
                }

                if (CarS.Current.State == 0)
                {
                    CarS.Current.CrossStreet();
                }
                else if (CarS.Current.State == 1)
                {
                    if (CarN.Current == null)
                    {
                        CarS.Current.CrossStreet();
                        Console.WriteLine("CarN is NULL");
                    }
                }
                else if (CarS.Current.State == 2)
                {
                    CarS.Current.CrossStreet();
                }
            }
        }

        public void NotifyForwardEW()
        {

            //foreach (var p in objects_)
            //{
            //    if (p.Location == 2 && p.State == 0)
            //    {
            //        p.CrossStreet();
            //        QueueW--;
            //    }
            //    else if (p.Location == 3 && p.State == 0)
            //    {
            //        p.CrossStreet();
            //        QueueE--;
            //    }
            //    else if (p.Location == 2 && p.State == 1)
            //    {
            //        p.CrossStreet();
            //        QueueW--;
            //    }
            //    else if (p.Location == 3 && p.State == 1)
            //    {
            //        p.CrossStreet();
            //        QueueE--;
            //    }
            //    else if (p.Location == 2 && p.State == 2)
            //    {
            //        if (QueueE > 0)
            //        {
            //            Console.WriteLine("Cant turn left from west waiting for opposite lane to clear");
            //        }
            //        else
            //        {
            //            p.CrossStreet();
            //            QueueW--;
            //        }
            //    }
            //    else if (p.Location == 3 && p.State == 2)
            //    {
            //        if (QueueW > 0)
            //        {
            //            Console.WriteLine("Cant turn left from east waiting for opposite lane to clear");
            //        }
            //        else
            //        {
            //            p.CrossStreet();
            //            QueueE--;
            //        }
            //    }
            //}
        }
    }
}
