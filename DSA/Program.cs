using System;

class Program
{
    static void greet()
    {
        Console.WriteLine("Good Morning Sir.. here I'm sending you the message");
    }
    static void greet1(String name)
    {
        Console.WriteLine("Good Morning Sir.. here I'm sending this message to " + name);
    }
    static float Average(int a, int b, int c)
    {
        float Sum = a + b + c;
        return Sum/3;
    }
    static void Main(string[] args)
    {
        HelloMan.SayHello();  // <-- use the method from Hello.cs

        int[] nums = { 5, 3, 8, 4, 2 };
        Array.Sort(nums);

        foreach (int n in nums)
            Console.Write(n + " ");

        /*
            Console.WriteLine("\nIt was my first in C sharp program");
            Console.WriteLine("I'm Learning New tech for my future placement");
            Console.Write("Thank you for your support");
            Console.Write(" :- Yes learn something\n");
        */
        int harry = 34;
        Console.WriteLine("Age of Harry is " + harry);

        /* string inp = Console.ReadLine(); // it was used in 2022 if you run it showing warning
        Console.WriteLine("String will be printed here : " + inp);
        Why the warning?
        In C# 8.0 and later, nullable reference types are enabled.
        Console.ReadLine() can return null (for example, if the user presses Ctrl+Z / Ctrl+D to signal end-of-input).Since you declared string inp as a non-nullable string, the compiler warns you.
        */

        /*
        string? inp1 = Console.ReadLine(); // option 1 & 2 is good to implement
        string inp2 = Console.ReadLine()!;
        string inp3 = Console.ReadLine()?? "add something new";
        Console.WriteLine("String will be printed here : " + inp1);
        Console.WriteLine("String1 will be printed here : " + inp2);
        Console.WriteLine("String2 will be printed here : " + inp3);
        */

        // TypeCasting & Datatypes examples
        /*
            int a = 35;
            float b = 35.5F;
            double c = 35.56D;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a + b); // here it converted the integer to float 
            Console.WriteLine(a + b + c);
            //Datatypes examples
            bool isgreat = true;
            Console.WriteLine(isgreat);
            char ch = 'r';
            Console.WriteLine(ch);
            string sr = "This is a string";
            Console.WriteLine(sr);
        */
        // TypeCasting
        int x = (int)34.5;
        Console.WriteLine(x);

        float varr = Convert.ToInt32(3.55);
        Console.WriteLine(varr);
        // User Inputs:

        /*
           Console.Write("Enter the name : ");
           string? name = Console.ReadLine();
           Console.WriteLine("Hey Hello " + name);
       */
        /*
            Console.Write("How many candies d you wants : ");
            string? can = Console.ReadLine();
            Console.WriteLine("You will gets " + can + 4); // Concatenation happend 
            Console.WriteLine("You will gets " + (Convert.ToInt32(can) + 4)); // Here Addition happend
        */

        // Operators in C#
        /*
        1. Arithematic operators
        2. Assignment operators
        3. Logical operators
        4. Comparsion operators
        1. 
        int c = 85;
        int d = 17;
        Console.WriteLine(c + d);
        Console.WriteLine(c - d);
        Console.WriteLine(c * d);
        Console.WriteLine(c / d);
        */

        // Math Operators
        /*
        int y = Math.Max(35, 158);
        Console.WriteLine(y);

        double z = 39;
        Console.WriteLine(z);

        int a = Math.Abs(-39);
        Console.WriteLine(a);

        string hello = "Hello World this is rishu";
        Console.WriteLine("Length of string : " + hello.Length);
        Console.WriteLine(hello.ToUpper());
        Console.WriteLine(hello.ToLower());

        Console.WriteLine(string.Concat("Hello Sir", " Can i get this job offers letters"));
        
        // String Interpolation
        string? name = Console.ReadLine();
        string? candies = Console.ReadLine();
        Console.WriteLine($"Your name is {name}. You will get {candies} candies");

        string hello = "Hello World this is rishu";
        Console.WriteLine(hello[0]);
        Console.WriteLine(hello.IndexOf("Hello"));
        Console.WriteLine(hello.IndexOf("is"));
        Console.WriteLine(hello.Substring(4));

        string? ani = "Excuse Mam\" i've one doubt\nrelated to this comapus drive";
        Console.WriteLine(ani);
        */


        // Decision Control : if-else condition
        /*
        Console.Write("Enter the age : ");
        string? AgeStr = Console.ReadLine();
        int age = Convert.ToInt32(AgeStr);
        if (age <= 5)
        {
            Console.WriteLine("You are just born..");
        }
        else if (age >= 18 && age <= 75)
        {
            Console.WriteLine("You are applicable to drive");
        }
        else if(age >= 75){
            Console.WriteLine("You are so old. you need to retire from driving need rest");
        }
        else
        {
            Console.WriteLine("You are not appliciable for drive & make sure you are above 18");
        }
    */

        // Loops in C#
        /*
        Console.Write("Enter the number: ");
        string? num = Console.ReadLine();
        int r = Convert.ToInt32(num);
        for (int i = 1; i < r; i++)
        {
            // Console.Write(i);
            Console.Write($" {i} ");

            // if (i != 5){
            //     Console.Write($" {i} ");
            //     continue;
            // }
        }
        Console.WriteLine();
        for (int i = 0; i < r; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.Write($" {i} ");
        }
    */
        // Methods : uses of Function

        /*
        Console.WriteLine("I'm accepting your greeting where are your message ");
        greet();
        greet1("Rishu");
        greet1("Riya");

        Console.WriteLine("Average of number is " + Average(8,9,5));
        */

        // OOPs : Object & Class

        Player tommy = new Player();
        Console.WriteLine("Class name is " + tommy);
        Console.WriteLine(tommy.name);
        Console.WriteLine(tommy.age);
        
        tommy.SetAge(45);
        Console.WriteLine("Updated age is " + tommy.age);
    }
}

