// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using EFCoreSample.Console.DataAccess;
using EFCoreSample.Console.Domain;
using Microsoft.EntityFrameworkCore;

using var studentContext = new StudentContext();

int studentId = await Create(studentContext);
await ReadAll(studentContext);

await Update(studentContext, studentId);
await ReadAll(studentContext);

await Delete(studentContext, studentId);
await ReadAll(studentContext);

Console.ReadLine();

static async Task<int> Create(StudentContext context)
{
    var student = new Student()
    {
        Address = "742 Evergreen Terrace",
        DateOfBirth = new DateOnly(1995, 6, 2),
        Email = "adsfs@adsf.com",
        FirstName = "John",
        LastName = "Doe",
        RegistryNumber = 12345,
        ZipCode = "80085"
    };

    context.Add(student);
    await context.SaveChangesAsync();

    return student.Id;
}

static async Task ReadAll(StudentContext context)
{
    var students = await context.Set<Student>().ToListAsync();

    var options = new JsonSerializerOptions()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    students.ForEach(s =>
    {
        string json = JsonSerializer.Serialize(s, options);
        Console.WriteLine(json);
    });

    Console.WriteLine($"Total count: {students.Count}");
    Console.WriteLine();
}

static async Task Update(StudentContext context, int studentId)
{
    var student = await context.FindAsync<Student>(studentId);

    student!.Email = "john.doe@frro.utn.edu.ar";

    await context.SaveChangesAsync();
}

static async Task Delete(StudentContext context, int studentId)
{
    var student = await context.FindAsync<Student>(studentId);

    context.Remove(student!);

    await context.SaveChangesAsync();
}
