using System;

namespace HomeWorkPAISTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xos Geldiniz Istifatecini yaradin");

            User user1 = new User("Eliyev Vusal","vusal1y3v@gmail.com","lotu6768");

            Console.WriteLine(user1.ShowInfo());
            Console.WriteLine("Passwordu girin");
            
            string password = Console.ReadLine();

            user1.PasswordCheker(password);

        }
    }
}
