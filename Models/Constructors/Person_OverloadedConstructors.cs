public class Person_OverloadedConstructors
{
    public string Name;
    public int Age;

    public Person_OverloadedConstructors() : this("Unknown") { }

    public Person_OverloadedConstructors(string name) : this(name, 0) { }

    public Person_OverloadedConstructors(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
