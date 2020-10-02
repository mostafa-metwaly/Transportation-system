using System;
using System.Collections.Generic;
using System.Text;

namespace transportation
{
    //ship class inheriting from transport and implements movebyswimming  interface module

    public class Ship : Transport, MovebySwimming
    {
        public Ship(string name, int weight, DateTime releaseDate) : base(name, weight, releaseDate)
        {
        }




        public override void Move()
        {
            Console.WriteLine("move using ship");
        }
        public void MovebySwimming()
        {
            Console.WriteLine("move by swimming");
        }
    }
}
