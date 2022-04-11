using System;

namespace HomeworkClass
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("12345678");
            user.Password = "12345678";
            Console.WriteLine(user.Password);
            
            
        }
    }
}
