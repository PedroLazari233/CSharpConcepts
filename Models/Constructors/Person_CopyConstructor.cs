public class Person_CopyConstructor
{
    public string Name;
    public int Age;

    public Person_CopyConstructor(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person_CopyConstructor(Person_CopyConstructor other)
    {
        Name = other.Name;
        Age = other.Age;
    }
}