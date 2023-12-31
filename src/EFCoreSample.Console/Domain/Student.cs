﻿namespace EFCoreSample.Console.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public int RegistryNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public DateTime CreatedTimestamp { get; set; }
        public Address? Address { get; set; }
    }
}
