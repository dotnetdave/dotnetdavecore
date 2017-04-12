using System;

namespace dotnetdaveCore
{
    public class RandomNameFinder : INameFinder
    {
        string INameFinder.GetName()
        {
            var names = new[] { "Dave", "John", "Lucas", "Michael", "Will", "Sean" };
            var random = new Random().Next(0, 6);
            return names[random];
        }
    }

}
