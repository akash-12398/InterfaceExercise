﻿using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany 
    {
       

        public double EngineSize { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int SeatCount { get; set; } 
        public string CompanyName { get; set; } 
        public string Logo { get; set; }
        public bool HasChangeGears { get; set; }


        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"$4 wheel drive { GetType().Name} now driving");
            }
            else
            Console.WriteLine($"{GetType().Name} now driving");
        }
        public void Reverse()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangeGears = false;
            }
            else
            {
                Console.WriteLine($"Can't reverse until we change gears ");
            }

        }
        public void Park()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangeGears = false;
            }
            else
            {
                Console.WriteLine($"Can't park until we change gears ");

            }

        }

        public bool Changegears()
        {
            throw new NotImplementedException();
        }


















    }
}
