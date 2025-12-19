using System;

namespace Lab4
{
    public class Car : Vehicle
    {
        public Car(double engineCapacity, string model, int year) : base(engineCapacity, model, year)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car Started");
        }

        public override void Test()
        {
            Console.WriteLine("Car test");
        }

        public void ShowMe()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}");
        }
    }
}