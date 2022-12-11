using System;
using System.Text;

namespace tests
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
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
            str =new string(arr);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
