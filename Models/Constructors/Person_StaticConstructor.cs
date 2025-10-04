public class Person_StaticConstructor
{
    public static int InstanceCount;

    static Person_StaticConstructor()
    {
        InstanceCount = 0;
    }

    public Person_StaticConstructor()
    {
        InstanceCount++;
    }
}