using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dog = new Dog("Spot", -5);

            }
            catch (ArgumentOutOfRangeException ex)
            {

                throw;
            }
            var dog = new Dog("Spot", -5);
            //dog.name = "Spot";
            //dog.age = 4;
        }
    }
}
