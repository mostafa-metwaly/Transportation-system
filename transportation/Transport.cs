using System;
using System.Collections.Generic;
using System.Text;

namespace transportation
{

    /// <summary>
    /// the main class base class that has name ,weight and releasedate attributes and main method Move which are inherited in every child class
    /// </summary>
    public abstract class Transport
    {
        public string name;
        public int weight;
        public DateTime releaseDate;
        

        public Transport(string name, int weight, DateTime releaseDate)
        {
            this.name = name;
            this.weight = weight;
            this.releaseDate = releaseDate;
        }
        //abstract method Move 
        public abstract void Move();
        
        

        
    
    }
}
