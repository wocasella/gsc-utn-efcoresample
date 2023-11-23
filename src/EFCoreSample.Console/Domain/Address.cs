namespace EFCoreSample.Console.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public Student Student { get; set; } = null!;
    }
}
