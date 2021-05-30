using System.Collections.Generic;
using Records.Models;

namespace Records.Business
{
    internal interface IComputerManager
    {
        IList<Computer> GetComputers();
    }

    internal class ComputerManager : IComputerManager
    {
        public IList<Computer> GetComputers()
        {
            var comp = new Computer()
            {
                Manufacturer = "Dell",
                ModelName = "8778",
                Price = 48478
            };

            var newComputer = comp with {ModelName = "8800", Price = 2000};
            
            return new List<Computer>()
            {
                //new Computer("Dell","7502",3453),
                new Computer() {Manufacturer = "Dell", ModelName = "7501", Price = 1999},
                new Computer() {Manufacturer = "Dell", ModelName = "5501", Price = 1099},
                new Computer() {Manufacturer = "Dell", ModelName = "7501", Price = 1999},
                newComputer,
                comp
            };

        }
    }
}
