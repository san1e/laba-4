using System;
using System.Linq;

namespace laba_4
{
    internal class Program
    {
        static string FirstVar(int n )
        {
            string str = "1";
            for (int i = 2; i <= n; i++)
            {
                str += " " + i;
            }
            return str;
        }
        static string SecondVar(int n)
        {
            string str = "5";
            for (int i = n-1; i >= 1; i--)
            {
                string temp =i + " ";
                str = str.Insert(0, temp);
            }
            return str;
        }
        static string ThirdVar(int n)
        {
            string str = "1";
            for (int i = 2; i <= n; i++)
            {
                str = str.Insert(0,Convert.ToString(i));

            }
            return str;
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("For FirstVar type 1");
                Console.WriteLine("For SecondVar type 2");
                Console.WriteLine("For ThirdVar type 3");
                Console.WriteLine("For FourthVar type 4");
                Console.WriteLine("To stop the programm type 0");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Type the length of the string");
                        int n = Convert.ToInt32(Console.ReadLine());
                        string str = FirstVar(n);
                        Console.WriteLine(str);
                        break;
                    case 2:
                        Console.WriteLine("Type the length of the string");
                        n = Convert.ToInt32(Console.ReadLine());
                        str = SecondVar(n);
                        Console.WriteLine(str);
                        break;
                    case 3:
                        Console.WriteLine("Type the length of the string");
                        n = Convert.ToInt32(Console.ReadLine());
                        str = ThirdVar(n);
                        Console.WriteLine(str);
                        break;
                    case 0:
                        Console.WriteLine("On more time push Enter to stop programm");
                        Console.ReadLine();
                        break;

                }
            } while (choice != 0);
            
        
        }
    }
}
