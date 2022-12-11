using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
            string str = $"{n}";
            for (int i = n-1; i >= 1; i--)
            {
                string temp =i + " ";
                str = str.Insert(0, temp);
            }
            return str;
        }
        static StringBuilder ThirdVar(int n)
        {
            StringBuilder str = new StringBuilder("1");
            for (int i = 2; i <= n; i++)
            {
                str = str.Append(" " + i);
            }
            return str;
        }
        static string FourthVar(int n)
        {
            string str = "1";
            string temp = "";
            for (int i = 2; i <= n; i++)
            {
                temp += " " + i;


            }
            str = str.Insert(1, temp);
            return str;
        
        }
        static string SecondTaskFirstVar(string str)
        {
            char[] arr = str.ToCharArray();
            char replacement = '-';
            for (int i = 1; i < str.Length; i++)
            {

                if (arr[i] == '+')
                {
                    if (arr[i - 1] % 2 != 0)
                    {
                        arr[i] = replacement;
                    }
                }

            }
            str = new string(arr);
            return str;
        }
        static StringBuilder SecondTaskSecondVar(string str)
        {
            StringBuilder str1 = new StringBuilder(str);
            char replacement = '-';
            for (int i = 1; i < str.Length; i++)
            {
                if (str1[i] == '+')
                {
                    if (str1[i - 1] % 2 != 0)
                    {
                        str1[i] = replacement;
                    }
                }

            }
            return str1;
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                global::System.Console.WriteLine("To do task 1 type 1");
                global::System.Console.WriteLine("To do task 2 type 2");
                Console.WriteLine("To stop the programm type 0");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
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
                                    Stopwatch stopwatch = new Stopwatch();
                                    int n = Convert.ToInt32(Console.ReadLine());
                                    stopwatch.Start();
                                    string str = FirstVar(n);
                                    Console.WriteLine(str);
                                    stopwatch.Stop();
                                    TimeSpan ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");
                                    break;
                                case 2:
                                    Console.WriteLine("Type the length of the string");
                                    stopwatch = new Stopwatch();
                                    n = Convert.ToInt32(Console.ReadLine());
                                    stopwatch.Start();
                                    str = SecondVar(n);
                                    Console.WriteLine(str);
                                    stopwatch.Stop();
                                    ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");
                                    break;
                                case 3:
                                    Console.WriteLine("Type the length of the string");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    stopwatch = new Stopwatch();
                                    stopwatch.Start();
                                    StringBuilder str1 = new StringBuilder();
                                    str1 = ThirdVar(n);
                                    Console.WriteLine(str1);
                                    stopwatch.Stop();
                                    ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");
                                    break;
                                case 4:
                                    Console.WriteLine("Type the length of the string");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    stopwatch = new Stopwatch();
                                    stopwatch.Start();
                                    str = FourthVar(n);
                                    Console.WriteLine(str);
                                    stopwatch.Stop();
                                    ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");
                                    break;
                                case 0:
                                    Console.WriteLine("On more time push Enter to stop programm");
                                    Console.ReadLine();
                                    break;

                            }
                        } while (choice != 0);
                        break;
                    case 2:
                        do
                        {
                            global::System.Console.WriteLine("For the String variant of task type 1");
                            global::System.Console.WriteLine("For the StringBuilder variant of task type 2");
                            global::System.Console.WriteLine("Type 0 to stop the programm");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    global::System.Console.WriteLine("Type your sequence");
                                    string str = Console.ReadLine();
                                    Stopwatch stopwatch = new Stopwatch();
                                    stopwatch.Start();
                                    string str1 = SecondTaskFirstVar(str);
                                    global::System.Console.WriteLine(str1);
                                    stopwatch.Stop();
                                    TimeSpan ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");

                                    break;
                                case 2:
                                    global::System.Console.WriteLine("Type your sequence");
                                    str = Console.ReadLine();
                                    stopwatch = new Stopwatch();
                                    stopwatch.Start();
                                    StringBuilder stb = SecondTaskSecondVar(str);
                                    global::System.Console.WriteLine(stb);
                                    stopwatch.Stop();
                                    ts = stopwatch.Elapsed;
                                    Console.WriteLine($"Time: {ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms");
                                    break;

                            }
                        } while (choice != 0);
                        break;
                }
                

               

                
            } while (choice != 0);
            
        
        }
    }
}
