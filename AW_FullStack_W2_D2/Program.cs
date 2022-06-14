using System;
using System.Collections.Generic;
using System.Linq;

namespace AW_FullStack_W2_D2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car("McLaren", "Mercedes AMG", "Norris", 805),
                new Car("Alpine", "Alpine", "Ocon", 802),
                new Car("Williams", "Mercedes AMG", "Albon", 811),
                new Car("Alfa Romeo", "Ferrari", "Bottas", 785),
                new Car("Red Bull Racing", "Red Bull", "Perez", 795),
                new Car("Ferrari", "Ferrari", "Leclerc", 798),
                new Car("Aston Martin", "Mercedes AMG", "Vettel", 809),
                new Car("Alpha Tauri", "Red Bull", "Gasly", 807),

            };


            

            IEnumerable<Car> result = carList.Where(auto => auto.CarWeight > 800);

            foreach(Car c in result)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(Environment.NewLine);


            result = from auto in carList
                     where auto.Motor == "Mercedes AMG" && auto.CarWeight > 800
                     select auto;



            foreach (Car c in result)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(Environment.NewLine);



            result = from c in carList
                     orderby c.CarWeight descending
                     select c;


            foreach (Car c in result)
            {
                Console.WriteLine(c);
            }


            var driverWithWeight = from c in carList
                                   select new { c.Driver, c.CarWeight };


            Console.WriteLine(Environment.NewLine);

            driverWithWeight.ToList().ForEach(tietorivi => Console.WriteLine(tietorivi.Driver + " " + tietorivi.CarWeight));
            

        }
    }

    class Car
    {
        public string Team { get; set; }
        public string Motor { get; set; }

        public string Driver { get; set; }

        public double CarWeight { get; set; }

        public Car(string team, string motor, string driver, double weight)
        {
            this.Team = team;
            this.Motor = motor;
            this.Driver = driver;
            this.CarWeight = weight;
        }

        public override string ToString()
        {
            return Team+ "-" + Motor + ": "+ Driver+ " Weight: "+CarWeight;
        }
    }
}
