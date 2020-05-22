using System;

class Program
{
    public static Main()
    {
        Console.WriteLine("Hello World!");
        SayHelloCity("Moscow");
        SayHelloName("Igor");
    }

    public void SayHelloCity(string city)
    {
    	Console.WriteLine("Hello city, " + {city} + "!");
    }

    public void SayHelloName(string name)
    {
    	Console.WriteLine("Hello darling, " + {name} + "!");
    }
}