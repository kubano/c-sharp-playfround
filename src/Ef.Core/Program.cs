using Microsoft.EntityFrameworkCore;

namespace Ef.Core;

/// <summary>
/// EF Core Helpers
/// </summary>
internal class Program
{
    protected Program()
    {
    }

    private static void Main()
    {
        /*
                       1. Provide migrations support to current project

                       2. Add all people to the database

                       3. Read all people from the database

                       4. Update a record by finding by name in the list and updating the Age, print the updated record

                       5. Group by Department

                       6. Traverse the resulting groups and print the department name and the number of people in that department
        */

        Console.WriteLine("Done!");
    }

    #region Helpers

    private interface IEntity
    {
        Guid Id { get; }
    }

    public class Person : IEntity
    {
        protected Person()
        {
        }

        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Department { get; private set; }
        public string City { get; private set; }

        public static Person Create(string name, int age, string department, string city) => new(name, age, department, city);

        private Person(string name, int age, string department, string city)
        {
            Name = name;
            Age = age;
            Department = department;
            City = city;
        }
    }

    public class AppDbContext : DbContext
    {
        // 7. Define a DbSet for the Person entity

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 8. Improve performance of the app by implementing split queries

            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }

    public static class Collections
    {
        public static IReadOnlyCollection<Person> People =>
        [
            Person.Create("John", 25, "HR", "New York"),
            Person.Create("Jane", 30, "IT", "Los Angeles"),
            Person.Create("Alice", 35, "Finance", "Chicago"),
            Person.Create("Bob", 40, "HR", "Houston"),
            Person.Create("Charlie", 45, "IT", "Phoenix"),
            Person.Create("David", 50, "Finance", "Philadelphia"),
            Person.Create("Eve", 55, "HR", "San Antonio"),
            Person.Create("Frank", 35, "IT", "San Diego"),
            Person.Create("Grace", 45, "Finance", "Dallas"),
            Person.Create("Henry", 47, "HR", "San Jose"),
            Person.Create("Ivy", 35, "IT", "Austin"),
            Person.Create("Jack", 56, "Finance", "Jacksonville"),
            Person.Create("Kelly", 45, "HR", "Indianapolis"),
            Person.Create("Larry", 38, "IT", "San Francisco"),
            Person.Create("Mary", 46, "Finance", "Columbus"),
            Person.Create("Nancy", 55, "HR", "Fort Worth"),
            Person.Create("Oliver", 44, "IT", "Charlotte"),
            Person.Create("Peter", 55, "Finance", "Detroit"),
            Person.Create("Quinn", 52, "HR", "El Paso"),
            Person.Create("Rose", 29, "IT", "Seattle"),
            Person.Create("Sam", 42, "Finance", "Denver"),
            Person.Create("Tom", 33, "HR", "Washington"),
            Person.Create("Ursula", 35, "IT", "Boston"),
            Person.Create("Victor", 40, "Finance", "Memphis"),
            Person.Create("Wendy", 45, "HR", "Nashville")
        ];
    }

    #endregion Helpers
}