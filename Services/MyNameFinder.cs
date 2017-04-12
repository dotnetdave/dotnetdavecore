namespace dotnetdaveCore
{
    public class MyNameFinder : INameFinder
    {
        string INameFinder.GetName()
        {
            return "Dave";
        }
    }

}
