namespace EFCoreSample.Console.Domain
{
    public class State
    {
        public short Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<City> Cities { get; } = new HashSet<City>();
    }
}
