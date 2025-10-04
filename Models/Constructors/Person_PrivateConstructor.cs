public class Person_PrivateConstructor
{
    public string Name;
    private static readonly Person_PrivateConstructor _instance = new("Singleton");

    private Person_PrivateConstructor(string name)
    {
        Name = name;
    }

    public static Person_PrivateConstructor Instance => _instance;
}