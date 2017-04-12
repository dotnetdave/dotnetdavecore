using System.Dynamic;
using Nancy;

namespace dotnetdaveCore.NancyModules
{
    public class ApiModule : NancyModule
    {
        public ApiModule(IGreetingService greeter) : base("/api")
        {
            Get("/", args =>
            {
                dynamic indexModel = new ExpandoObject();
                indexModel.Hello = greeter.SayHello();
                indexModel.goodby = greeter.SayGoodbye();
                return  indexModel;
            });
        }
    }
}