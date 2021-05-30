namespace Records.Models
{
    //internal record Computer(string ModelName, string Manufacturer, int Price);
    internal record Computer
    {
        public string ModelName { get; init; }
        public string Manufacturer { get; init; }
        public int Price { get; init; }
    }


    //internal class Computer
    //{
    //    public string ModelName { get; set; }
    //    public string Manufacturer { get; set; }
    //    public int Price { get; set; }

    //    public override string ToString()
    //    {
    //        return $"ModelName: {ModelName}, Manufacturer: {Manufacturer}, Price: {Price}";
    //    }
    //}

    internal class ComputerObj
    {
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"ModelName: {ModelName}, Manufacturer: {Manufacturer}, Price: {Price}";
        }
    }
}
