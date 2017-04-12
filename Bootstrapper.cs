using Nancy;
using Nancy.Configuration;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.DryIoc;
using DryIoc;
namespace dotnetdaveCore
{
    public class Bootstrapper : DryIocNancyBootstrapper
    {

        public override void Configure(INancyEnvironment environment)
        {
            environment.Tracing(
                enabled: true,
                displayErrorTraces: true);


        }

        protected override void ApplicationStartup(IContainer container, IPipelines pipelines)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during application startup.
        }

        protected override void ConfigureApplicationContainer(IContainer existingContainer)
        {
            // Perform registation that should have an application lifetime
            existingContainer.Register<IGreetingService, HardCodedGreetingService>(Reuse.Singleton);
            existingContainer.Register<INameFinder, RandomNameFinder>(Reuse.Transient);
            existingContainer.Register<IHelloFinder, MyHelloFinder>(Reuse.Transient);
        }

        protected override void ConfigureRequestContainer(IContainer container, NancyContext context)
        {
            // Perform registrations that should have a request lifetime
        }

        protected override void RequestStartup(IContainer container, IPipelines pipelines, NancyContext context)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during request startup.
        }
    }
}