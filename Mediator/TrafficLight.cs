using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface TrafficLight
    {
        void NotifyForward();
        void NotifyForward2();
    }


    public class ConcreteTrafficLight : TrafficLight
    {
        private List<Object> objects_;
        public int queueN=0, QueueS=0, QueueW=0, QueueE=0;
        private List<ConcreteCar> o_;
        private List<ConcretePerson> p_;

        public ConcreteTrafficLight(List<ConcreteCar> o, List<ConcretePerson> persons)
        {
            objects_=new List<Object>();
            p_ = persons;
            o_ = o;
            objects_.AddRange(o_);
            objects_.AddRange(p_);
            

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

        public void NotifyForward()
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


        public void NotifyForward2()
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
