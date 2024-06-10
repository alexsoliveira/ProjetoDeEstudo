namespace UsingValueTypes;

public class AulaUsingValueTypes()
{
    enum Titles { Mr, Ms, Mrs, Dr };
    

    public void AulaBuiltInValueTypes()
    {
        //int? idade = null;
        //System.Nullable<int> idade = null;
        int idade = 0; //não permite colocar o valor "null"
        //System.Int32 idade = 0;
        idade = 30;
        Console.WriteLine("Idade: " + idade);
        bool verdade = true;
        Console.WriteLine("Verdadeiro: " + verdade);
    }

    public void AulaEnumerations()
    {
        Titles titles = Titles.Mr;
        Console.WriteLine("{0}. ", titles);
    }
}

struct Person
{
    public string firstName;
    public string lastName;
    public int age;
    public Genders gender;

    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
        firstName = _firstName;
        lastName = _lastName;
        age = _age;
        gender = _gender;
    }

    override public string ToString()
    {
        return firstName + " " + lastName + " (" + gender +"), age " + age;
    }

    public enum Genders 
    {
        
        Male,
        Female,
    }
}

