using System;

namespace transportation
{
   public class Program
    {
        //Main Program execution for creating and moving each and every transport class
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 200,  DateTime.Now);
            Airplane airplane = new Airplane("Boeing", 200, DateTime.Now);
            Ship ship = new Ship("normandy", 200, DateTime.Now);

            
            car.Move();
            ship.Move();
            airplane.Move();
            ship.MovebySwimming();
            airplane.MovebyFlying();
        }
    }
}
