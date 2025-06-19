
using HelloWorld.Models;
namespace HelloWorld
{
    class program
    {
        //Entry Point
        public static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Mon");
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Console.WriteLine(employee1.Equals(employee2));
            Console.ReadLine();
        }
        
    }
}
