using Microsoft.AspNetCore.Hosting;
using Nancy;
using Nancy.Configuration;
using Nancy.Conventions;

public class AppNancyBootstrapper : DefaultNancyBootstrapper
{
    public AppNancyBootstrapper(IHostingEnvironment environment)
    {
        RootPathProvider = new AppRootPathProvider(environment);
    }

    public override void Configure(INancyEnvironment environment)
    {
        base.Configure(environment);

        environment.Tracing(enabled: false, displayErrorTraces: true);
    }

    protected override void ConfigureConventions(NancyConventions conventions)
    {
        base.ConfigureConventions(conventions);

        conventions.StaticContentsConventions.AddDirectory("assets");
    }

    protected override IRootPathProvider RootPathProvider { get; }
}
