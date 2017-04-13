namespace dotnetdaveCore
{
    public class FancyGreetingService : IGreetingService
    {
        private readonly INameFinder namefinder;
        private readonly IHelloFinder helloFinder;

        public FancyGreetingService(INameFinder namefinder, IHelloFinder helloFinder)
        {
            this.namefinder = namefinder;
            this.helloFinder = helloFinder;
        }
        
        public string SayHello()
        {
            return $"{helloFinder.GetHello()} {namefinder.GetName()}";
        }

        public string SayGoodbye()
        {
            return $"See ya {namefinder.GetName()}";
        }

    }
}
