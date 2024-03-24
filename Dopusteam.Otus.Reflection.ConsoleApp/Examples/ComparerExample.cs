using Dopusteam.Otus.Reflection.Comparer;

namespace Dopusteam.Otus.Reflection.ConsoleApp.Examples;

public static class ComparerExample
{
    public static void Run()
    {
        var first = new ComparableItem("1", "FirstName", "123");
        var second = new ComparableItem("2", "FirstName", "1234");

        var differences = ObjectsComparer.GetDifference(first, second);

        Console.WriteLine(differences);
    }
}

public class ComparableItem
{
    public string Id { get; }

    public string Name { get; }
    
    public string LastName { get; }
    

    public ComparableItem(string id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
}