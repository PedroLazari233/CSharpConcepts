using System;

namespace CSharpConcepts.Models.UsingDirectives
{
    // Explicit showing which namespace this class is using
    class CommonUsing
    {
        public void Sqrt()
        {
            var sqrt = Math.Sqrt(9);
        }
    }
}
