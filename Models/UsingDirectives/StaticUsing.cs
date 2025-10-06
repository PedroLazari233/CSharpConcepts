using static System.Math;

namespace CSharpConcepts.Models.UsingDirectives
{
    // The using static directive names a type whose static members and nested types
    class StaticUsing
    {
        public void ComputeSqrt() // If this method is called Sqrt we would have a problem. Check QualifiedUsing class
        {
            var sqrt = Sqrt(9);
        }
    }
}
