namespace dotnetdaveCore
{
    public class HardCodedGreetingService : IGreetingService
    {
        public string SayHello()
        {
            return "Hello Lucas";
        }

           public string SayGoodbye()
        {
            return "Adios Lucas";
        }
    }
}
