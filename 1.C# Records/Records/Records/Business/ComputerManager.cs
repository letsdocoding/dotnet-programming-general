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
            return new List<Computer>()
            {
                new Computer() {Manufacturer = "Dell", ModelName = "7501", Price = 1999},
                new Computer() {Manufacturer = "Dell", ModelName = "5501", Price = 1099},
            };
        }
    }
}
