// Global settings
Globals = Obj(new
{
    debugOn = true,
    detailedAclDebug = false,
    aclOn = false,
    isSpa = true,
    port = 3001,
    serverName = "Ironboy's Minimal API Server",
    frontendPath = Path.Combine("..", "Frontend"),
    sessionLifeTimeHours = 2
});

// Server.Start();
namespace WebApp
{
    class App
    {
        static void Main(string[] args)
        {
            string password = "MySecurePassword123!";
            bool isGoodEnough = WebApp.Utils.IsStrongPassword(password);
            // You can use isGoodEnough as needed in your application logic
        }
    }
}
