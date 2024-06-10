using UsingValueTypes;

namespace Estrutura;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        //ValueTypes();
        LabValueTypes();
    }

    public static void LabValueTypes()
    {
        Person person = new Person("Tony","Allen",32, Person.Genders.Male);
        
        Console.WriteLine(person.ToString());
        Console.ReadLine();
    }

    public static void ValueTypes()
    {
        AulaUsingValueTypes valueTypes = new AulaUsingValueTypes();
        //valueTypes.AulaBuiltInValueTypes();
        valueTypes.AulaEnumerations();
    }
}
