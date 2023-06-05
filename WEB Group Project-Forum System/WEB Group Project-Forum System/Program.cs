using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
            
            
        }
    }
}