using System;

namespace dotnetdaveCore
{
    public class MyHelloFinder : IHelloFinder
    {
      public  string GetHello()
        {
            var names = new[] { "Hi", "Bonjour", "Welcome", "Oi Oi", "Watcha", "Alright" };
            var random = new Random().Next(0, 6);
            return names[random];
        }
    }
}
