﻿
   


namespace homevork 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
        Console.WriteLine("Знакомство");
        Console.WriteLine("Как тебя зовут?");
        string myname;
        myname = Console.ReadLine();
        Console.WriteLine("Привет, "+ myname);
        Console.WriteLine("Нажмите любую клавишу для выхода из программы");
        Console.ReadLine();

        } 
    }
}
