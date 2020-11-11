using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public double EngineSize { get; set; } = 3.6;
        public string Make { get; set; } = "Acura";
        public string Model { get; set; } = "RDX";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Honda";
        public string Motto { get; set; } = "The Power of Dreams";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = false;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
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
