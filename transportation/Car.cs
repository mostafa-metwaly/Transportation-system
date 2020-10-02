using System;
using System.Collections.Generic;
using System.Text;

namespace transportation
{
    //car class inheriting from transport main class

    public class Car : Transport
    {
        public Car(string name, int weight, DateTime releaseDate) : base(name, weight, releaseDate)
        {
        }

        public override void Move()
        {
            Console.WriteLine("move using car");
        }

    }
}
