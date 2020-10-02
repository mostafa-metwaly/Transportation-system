using System;
using System.Collections.Generic;
using System.Text;

namespace transportation
{
    //Airplane class inheriting from transport and implements movebyflying interface module
    public class Airplane : Transport, MovebyFlying
    {
        
        public Airplane(string name, int weight, DateTime releaseDate) : base(name, weight, releaseDate)
        {
        }

        public override void Move()
        {
            Console.WriteLine("move using Airplane");
        }

        public void MovebyFlying()
        {
            Console.WriteLine("move by flying");
        }
    }
}
