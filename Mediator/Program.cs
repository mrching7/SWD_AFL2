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
            List<ConcreteCar> CarsNorth = new List<ConcreteCar>();
            List<ConcreteCar> CarsSouth = new List<ConcreteCar>();
            List<ConcreteCar> CarsEast = new List<ConcreteCar>();
            List<ConcreteCar> CarsWest = new List<ConcreteCar>();
            List<ConcretePerson> PersonNorth = new List<ConcretePerson>();
            List<ConcretePerson> PersonSouth = new List<ConcretePerson>();
            List<ConcretePerson> PersonEast = new List<ConcretePerson>();
            List<ConcretePerson> PersonWest = new List<ConcretePerson>();


            for (int i = 0; i <= 2; i++)
            {
                Thread.Sleep(2);
                CarsNorth.Add(new ConcreteCar());
                Thread.Sleep(2);
                CarsSouth.Add(new ConcreteCar());
                Thread.Sleep(2);
                CarsEast.Add(new ConcreteCar());
                Thread.Sleep(2);
                CarsWest.Add(new ConcreteCar());
                Thread.Sleep(2);
                PersonNorth.Add(new ConcretePerson());
                Thread.Sleep(2);
                PersonSouth.Add(new ConcretePerson());
                Thread.Sleep(2);
                PersonEast.Add(new ConcretePerson());
                Thread.Sleep(2);
                PersonWest.Add(new ConcretePerson());
                Thread.Sleep(2);
            }

            ConcreteTrafficLight concreteTraffic = new ConcreteTrafficLight(CarsNorth, CarsSouth, CarsEast, CarsWest, PersonNorth, PersonSouth, PersonEast, PersonWest);

            concreteTraffic.NotifyForwardNS();
            Thread.Sleep(2000);
            concreteTraffic.NotifyForwardEW();

        }
    }
}