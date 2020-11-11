using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 2.5;
        public string Make { get; set; } = "Suburu";
        public string Model { get; set; } = "Legacy";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Suburu Corporation";
        public string Motto { get; set; } = "Love. It's What Makes a Subaru, a Subaru";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }     
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse untill we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse untill we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
