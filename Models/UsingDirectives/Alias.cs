using m = System.Math;

namespace CSharpConcepts.Models.UsingDirectives
{
    class Alias
    {
        public void Sqrt()
        {
            var sqrt = m.Sqrt(9); // No need of System.Math.Sqrt
        }
    }
}
