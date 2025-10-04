using System;

namespace ConstructorsExamples.Demos
{
    public static class ConstructorsDemo
    {
        public static void Run()
        {
            DefaultConstructor();
            ParameterizedConstructor();
            OverloadedConstructors();
            StaticConstructor();
            CopyConstructor();
            PrivateConstructor();
            PrimaryConstructor();
        }

        private static void DefaultConstructor()
        {
            Console.WriteLine("=== DEFAULT CONSTRUCTOR ===");
            var person = new Person_DefaultConstructor();
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}\n");
        }

        private static void ParameterizedConstructor()
        {
            Console.WriteLine("=== PARAMETERIZED CONSTRUCTOR ===");
            var person = new Person_ParameterizedConstructor("Alice", 25);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}\n");
        }

        private static void OverloadedConstructors()
        {
            Console.WriteLine("=== OVERLOADED CONSTRUCTORS ===");
            var p1 = new Person_OverloadedConstructors();
            var p2 = new Person_OverloadedConstructors("Bob");
            var p3 = new Person_OverloadedConstructors("Charlie", 40);

            Console.WriteLine($"Overload 1 -> Name: {p1.Name}, Age: {p1.Age}");
            Console.WriteLine($"Overload 2 -> Name: {p2.Name}, Age: {p2.Age}");
            Console.WriteLine($"Overload 3 -> Name: {p3.Name}, Age: {p3.Age}\n");
        }

        private static void StaticConstructor()
        {
            Console.WriteLine("=== STATIC CONSTRUCTOR ===");
            var s1 = new Person_StaticConstructor();
            var s2 = new Person_StaticConstructor();
            Console.WriteLine($"Instance count: {Person_StaticConstructor.InstanceCount}\n");
        }

        private static void CopyConstructor()
        {
            Console.WriteLine("=== COPY CONSTRUCTOR ===");
            var original = new Person_CopyConstructor("Diana", 28, ["fishing", "gaming"]);
            var copy = new Person_CopyConstructor(original);

            Console.WriteLine($"Original -> Name: {original.Name}, Age: {original.Age}, Hobbies: {original.Hobbies[0]}, {original.Hobbies[1]}");
            Console.WriteLine($"Copy     -> Name: {copy.Name}, Age: {copy.Age}, Hobbies: {copy.Hobbies[0]}, {copy.Hobbies[1]}\n");
        }

        private static void PrivateConstructor()
        {
            Console.WriteLine("=== PRIVATE CONSTRUCTOR (SINGLETON) ===");
            var i1 = Person_PrivateConstructor.Instance;
            var i2 = Person_PrivateConstructor.Instance;

            Console.WriteLine($"Singleton Name: {i1.Name}");
            Console.WriteLine($"Are both instances equal? {ReferenceEquals(i1, i2)}\n");
        }

        private static void PrimaryConstructor()
        {
            Console.WriteLine("=== PRIMARY CONSTRUCTOR (RECORD STYLE) ===");
            var pri = new Person_PrimaryConstructor("Eva", 32);
            Console.WriteLine($"Name: {pri.Name}, Age: {pri.Age}\n");
        }
    }
}
