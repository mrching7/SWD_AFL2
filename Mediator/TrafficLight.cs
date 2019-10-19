
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface TrafficLight
    {
        void NotifyForwardNS();
        void NotifyForwardEW();
    }


    public class ConcreteTrafficLight : TrafficLight
    {
        private List<Object> objects_;
        public int queueN=0, QueueS=0, QueueW=0, QueueE=0;

        public ConcreteTrafficLight(List<ConcreteCar> CarsNorth, 
                                    List<ConcreteCar> CarsSouth, 
                                    List<ConcreteCar> CarsEast, 
                                    List<ConcreteCar> CarsWest,
                                    List<ConcretePerson> PersonsNorth,
                                    List<ConcretePerson> PersonsSouth,
                                    List<ConcretePerson> PersonsEast,
                                    List<ConcretePerson> PersonsWest
                                    )
        {
            objects_=new List<Object>();

            objects_.AddRange(CarsNorth);
            objects_.AddRange(CarsSouth);
            objects_.AddRange(CarsEast);
            objects_.AddRange(CarsWest);

            objects_.AddRange(PersonsNorth);
            objects_.AddRange(PersonsSouth);
            objects_.AddRange(PersonsEast);
            objects_.AddRange(PersonsWest);  


            foreach (var p in objects_)
            {
                if (p.Location==0)
                {
                    queueN++;
                }
                else if (p.Location==1)
                {
                    QueueS++;
                }
                else if (p.Location == 2)
                {
                    QueueW++;
                }
                else if (p.Location == 3)
                {
                    QueueE++;
                }
            }
        }

        public void NotifyForwardNS()
        {
            foreach (var p in objects_)
            {
                
                if (p.Location == 0 && p.State == 0)
                {
                    p.CrossStreet();
                    queueN--;
                }
                else if (p.Location == 1 && p.State == 0)
                {
                    p.CrossStreet();
                    QueueS--;
                }
                else if (p.Location==0 && p.State==1)
                {
                    p.CrossStreet();
                    queueN--;
                }
                else if (p.Location == 1 && p.State == 1)
                {
                    p.CrossStreet();
                    QueueS--;
                }
                else if (p.Location == 0 && p.State == 2)
                {
                    if (QueueS > 0)
                    {
                        Console.WriteLine("Cant turn left from north waiting for opposite lane to clear");
                    }
                    else
                    {
                        p.CrossStreet();
                        queueN--;
                    }
                }
                else if (p.Location == 1 && p.State == 2)
                {
                    if (QueueS > 0)
                    {
                        Console.WriteLine("Cant turn left from south waiting for opposite lane to clear");
                    }
                    else
                    {
                        p.CrossStreet();
                        QueueS--;
                    }
                }
                
            }
        }


        public void NotifyForwardEW()
        {

            foreach (var p in objects_)
            {
                if (p.Location == 2 && p.State == 0)
                {
                    p.CrossStreet();
                    QueueW--;
                }
                else if (p.Location == 3 && p.State == 0)
                {
                    p.CrossStreet();
                    QueueE--;
                }
                else if (p.Location == 2 && p.State == 1)
                {
                    p.CrossStreet();
                    QueueW--;
                }
                else if (p.Location == 3 && p.State == 1)
                {
                    p.CrossStreet();
                    QueueE--;
                }
                else if (p.Location == 2 && p.State == 2)
                {
                    if (QueueE > 0)
                    {
                        Console.WriteLine("Cant turn left from west waiting for opposite lane to clear");
                    }
                    else
                    {
                        p.CrossStreet();
                        QueueW--;
                    }
                }
                else if (p.Location == 3 && p.State == 2)
                {
                    if (QueueW > 0)
                    {
                        Console.WriteLine("Cant turn left from east waiting for opposite lane to clear");
                    }
                    else
                    {
                        p.CrossStreet();
                        QueueE--;
                    }
                }

            }




        }
    }

}