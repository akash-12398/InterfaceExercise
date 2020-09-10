using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany

    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Honda";
        public string Logo { get; set; } = "Buit NewTech";
        public bool HasChangeGears { get; set; }

        public void Drive()
        {
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

        public void Changegears(bool isChanged)
        {
            HasChangeGears = isChanged;
        }

        public bool Changegears()
        {
            throw new NotImplementedException();
        }
    }
    
}
