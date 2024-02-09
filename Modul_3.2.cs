using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName;

        MyName = "Vadim";

        Console.WriteLine(MyName);

        Console.WriteLine("\t Привет Мир");
        Console.WriteLine("\t Мне 27 лет");
        Console.WriteLine("\t My name is \n {0}", MyName);
        Console.WriteLine("\u0040"); //вывод символа @
        Console.WriteLine("\u0023"); //вывод символа #

        Console.ReadKey();
    }
}