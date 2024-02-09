//Работа с разными типами данных
using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

    }
}

//Возможность узнать минимальные и максимальные значения типа без их запоминания
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("IntMin {0} ", int.MinValue);
        Console.WriteLine("IntMax {0} ", int.MaxValue);
    }
}