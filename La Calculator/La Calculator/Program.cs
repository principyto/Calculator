using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LaCalculator
{
    static void Main()
    {
        int a;
        int b;
        string ex;
        Console.WriteLine("Insert First Value");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select Operation: +, -, *, /");
        CheckForOperation();
        void CheckForOperation()
        {
            ex = Console.ReadLine();
            if (ex == "+" || ex == "-" || ex == "*" || ex == "/")
            {
                Console.WriteLine("Select second value");
                CheckForError();
            }
            else
            {
                Console.WriteLine("Invalid operator");
                CheckForOperation();
            }
        }
        void CheckForError()
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0 & ex == "/")
            {
                Console.WriteLine("Cant divide by 0, select other number");
                CheckForError();
            }
            else
            {
                switch (ex)
                {
                    case "+": Console.WriteLine(a + b); break;
                    case "-": Console.WriteLine(a - b); break;
                    case "*": Console.WriteLine(a * b); break;
                    case "/": Console.WriteLine(a / b); break;
                }
                
            }
        }
        Main();
          
    }
}
