using Nancy;

public class AppNancyModule : NancyModule
{
    public AppNancyModule()
    {
        Get("/", _ => View["index"]);
    }
}
