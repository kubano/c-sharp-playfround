namespace Collections;

/// <summary>
/// C# Language Features - Collections
/// </summary>
internal class Program
{
    protected Program()
    {
    }

    public static void Main()
    {
        var people = Collections.People;

        // given the following example of a Person to Be Found by name, update Age to 60 and print the updated record (write example below, explain the result of the code)
        var personToBeFound = people.Single(p => p.Name.Equals("Moana"));

        // given an index 27, remove the person from the list (explain why this is not a good idea, and what's the result of the following code)
        var personToRemove = people.ElementAt(27);

        Console.WriteLine(personToRemove);
    }
}

#region Helpers

public record Person(string Name, int Age, string Department, string City);

public static class Collections
{
    public static IReadOnlyCollection<Person> People =>
    [
        new Person("John", 25, "HR", "New York"),
        new Person("Jane", 30, "IT", "Los Angeles"),
        new Person("Alice", 35, "Finance", "Chicago"),
        new Person("Bob", 40, "HR", "Houston"),
        new Person("Charlie", 45, "IT", "Phoenix"),
        new Person("David", 50, "Finance", "Philadelphia"),
        new Person("Eve", 55, "HR", "San Antonio"),
        new Person("Frank", 35, "IT", "San Diego"),
        new Person("Grace", 45, "Finance", "Dallas"),
        new Person("Henry", 47, "HR", "San Jose"),
        new Person("Ivy", 35, "IT", "Austin"),
        new Person("Jack", 56, "Finance", "Jacksonville"),
        new Person("Kelly", 45, "HR", "Indianapolis"),
        new Person("Larry", 38, "IT", "San Francisco"),
        new Person("Mary", 46, "Finance", "Columbus"),
        new Person("Nancy", 55, "HR", "Fort Worth"),
        new Person("Oliver", 44, "IT", "Charlotte"),
        new Person("Peter", 55, "Finance", "Detroit"),
        new Person("Quinn", 52, "HR", "El Paso"),
        new Person("Rose", 29, "IT", "Seattle"),
        new Person("Sam", 42, "Finance", "Denver"),
        new Person("Tom", 33, "HR", "Washington"),
        new Person("Ursula", 35, "IT", "Boston"),
        new Person("Victor", 40, "Finance", "Memphis"),
        new Person("Wendy", 45, "HR", "Nashville")
    ];
}

#endregion Helpers