using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            List <ConcreteCar> C = new List<ConcreteCar>();
            List<ConcretePerson> P = new List<ConcretePerson>();
            #region MyRegion
            ConcreteCar C1=new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C2 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C3 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C4 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C5 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C6 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C7 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C8 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C9 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C10 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C11 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C12 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C13 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C14 = new ConcreteCar();

            ConcretePerson p1 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p2 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p3 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p4 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p5 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p6 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p7 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p8 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p9 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p10 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p11 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p12 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p13 = new ConcretePerson();
            Thread.Sleep(20);
            ConcretePerson p14 = new ConcretePerson();
            Thread.Sleep(20);
            #endregion

            #region myregion2
            C.Add(C1);
            C.Add(C2);
            C.Add(C3);
            C.Add(C4);
            C.Add(C5);
            C.Add(C6);
            C.Add(C7);
            C.Add(C8);
            C.Add(C9);
            C.Add(C10);
            C.Add(C11);
            C.Add(C12);
            C.Add(C13);
            C.Add(C14);
            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            P.Add(p4);
            P.Add(p5);
            P.Add(p6);
            P.Add(p7);
            P.Add(p8);
            P.Add(p9);
            P.Add(p10);
            P.Add(p11);
            P.Add(p12);
            P.Add(p13);
            P.Add(p14);
            #endregion

            ConcreteTrafficLight concreteTraffic=new ConcreteTrafficLight(C, P);

            concreteTraffic.NotifyForwardNS();
            Thread.Sleep(2000);
            concreteTraffic.NotifyForwardEW();

        }
    }
}
