public class Person_CopyConstructor
{
    public string Name;
    public int Age;
    public List<string>? Hobbies;

    public Person_CopyConstructor(string name, int age, List<string>? hobbies)
    {
        Name = name;
        Age = age;
        Hobbies = hobbies;
    }

    /// <summary>
    /// Copy constructor: creates a new object as a copy of an existing one.
    /// 
    /// ⚠️ Important notes:
    /// - This performs a **shallow copy** by default.
    ///   - Value types (int, double, etc.) and immutable types (string) are copied by value.
    ///   - Reference types (like lists or other objects) are copied by reference, meaning both objects share the same instance.
    /// - To avoid unexpected side effects, you may need to implement a **deep copy** by creating new instances for reference-type fields.
    /// </summary>
    /// <param name="original">The object to copy.</param>
    public Person_CopyConstructor(Person_CopyConstructor original)
    {
        Name = original.Name;
        Age = original.Age;
        Hobbies = original.Hobbies; // Shallow copy: shared reference
        // Hobbies = new List<string>(original.Hobbies); // Deep copy: independent copy
    }
}