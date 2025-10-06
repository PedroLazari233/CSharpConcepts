namespace CSharpConcepts.Models.UsingDirectives
{
    // Explicit showing which namespace this class is using
    class GlobalUsing
    {
        public void HavingAList()
        {
            var list = new List<string>(); // JsonCommentHandling line 1 of GlobalUsing.cs in root project
        }
    }
}
