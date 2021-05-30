namespace Records.Models
{
    internal class Computer
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
