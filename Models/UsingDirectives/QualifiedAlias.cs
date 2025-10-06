namespace CSharpConcepts.Models.UsingDirectives
{
    // The global:: ensures that the namespace lookup for the namespace following the :: token is relative to the global namespace
    class QualifiedAlias
    {
        public void Sqrt()
        {
            var sqrt = global::System.Math.Sqrt(9);
        }
    }
}
