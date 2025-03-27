
using C13.lib;
using chapter01;

class Program
{
    static void Main()
    {
        var cop = new Money(100, "COP");
        var cop2 = new Money(100, "COP");

        var user = new User { id = 1, userName = "user1" };
        var user2 = new User { id = 1, userName = "user1" };


            Console.WriteLine(cop == cop2);

        if (user == user2)
            Console.WriteLine("Users IGuales");
        else Console.WriteLine("Error users");

    }
}