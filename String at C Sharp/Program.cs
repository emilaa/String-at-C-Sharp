using System;

namespace String_at_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "E", "m", "i", "l" };
            Name(names);
        }
       
        //1.Reverse the name.
        static void Name(string[] names)
        {
            int count = 0;

            for (int i = 3; i < names.Length; i--)
            {
                count--;
                
                Console.WriteLine(names[i]);
            }
        }
    }
}