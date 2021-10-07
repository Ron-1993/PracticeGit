using System;


class HelloWorld
{
    static void Main()
    {
        string max, miniMax,name;
        int money;
        var ( A, B) = ("momther", "Fuck");
        string[,] language ={
            {"C#", "123", "C++"},
            {"java","javascript","456"},
        };

        
        
        miniMax = "Hello World! I'm FunFun";
        max = "Who are you?";
        Console.WriteLine(miniMax);
        Console.Write(max);
        name = Console.ReadLine();
        Console.WriteLine($"Hello {name} How much money do you have?");
        money = int.Parse(Console.ReadLine());;
        
        Console.WriteLine($"Wow {A} {B}! you have {money} doller! you are rich!");
        Console.WriteLine($"there {language[1,2]} in this pargram");
        Console.WriteLine(language.Length);
        Console.WriteLine("Make some change");
        Console.WriteLine("Make some change3");
        
        Console.WriteLine("Make some change2");
        
    } 
}



