using SoftUni.Data;

namespace SoftUni

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine("Database created successfully!");
        }
    }

}
