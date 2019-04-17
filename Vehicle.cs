using System;

namespace garysgarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

         public virtual void Drive () {
        Console.WriteLine("Vrooom!");
    }

    public virtual void Turn () {
        Console.WriteLine("squeals around a right turn!");
    }

    public virtual void Stop () {
        Console.WriteLine("comes to a screeching halt!");
    }


    }
}