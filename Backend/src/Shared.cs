namespace WebApp;
public static class Shared
{
    // A global object to store settings in
    private static Obj _globals = Obj();

    public static dynamic Globals
    {
        get { return _globals; }
        set { _globals = value; }
    }

    // A setter/getter for the WebApp
    // (created by Server.cs)
    private static WebApplication _app;

    public static WebApplication App
    {
        get { return _app!; }
        set { _app = value; }
    }

    // Now - time now as unix timestamp in milliseconds
    public static long Now
    {
        get
        {
            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);
            return dto.ToUnixTimeMilliseconds();
        }
    }
}