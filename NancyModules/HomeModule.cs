using System.Dynamic;
using Nancy;

namespace dotnetdaveCore.NancyModules
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IGreetingService greeter)
        {
            Get("/", args =>
            {
                dynamic indexModel = new ExpandoObject();
                indexModel.Hello = greeter.SayHello();
                return View["index.html", indexModel];
            });
        }
    }
}