using System;
using Records.Business;
using Records.Models;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerManager computerManager = new();
            var computers = computerManager.GetComputers();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }

            //test with class type
            var comp1 = new ComputerObj {ModelName = "Dell", Manufacturer = "7501", Price = 100};
            var comp2 = new ComputerObj {ModelName = "Dell", Manufacturer = "7501", Price = 100};

            Console.WriteLine($"Equality for class type : {comp1 == comp2}");
            Console.WriteLine($"Equality for record type : {computers[0] == computers[2]}");
            Console.ReadLine();
        }
    }
}
