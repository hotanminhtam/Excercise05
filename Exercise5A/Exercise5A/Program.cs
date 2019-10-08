using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_to_z_v1();
            Print_z_to_a();
            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(" " + Char2Code(c));
            }
        }

        public static void Print_a_to_z_v1()
        {
            char c = ' ';
            for (int i = 97; i < 122; i++)
            {
                c = (char)i;
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static void Print_a_to_z_v2()
        {
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(c);
                c++;
            }
        }

        public static void Print_a_to_z_v3()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }

        public static void Print_a_to_z_v4()
        {
            string c = "abcdefghijklmnopqrstuvwxy";
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }

        public static void Print_z_to_a()
        {
            char c = ' ';
            for (int i = 122; i >= 97; i--)
            {
                c = (char)i;
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static int Char2Code(char c)
        {
            return (int)c;
        }

        public static bool IsUpper(char c)
        {
            return false;
        }

        public static bool IsLower(char c)
        {
            return false;
        }

        public static char ToUpper(char c)
        {
            return c;
        }

        public static char ToLower(char c)
        {
            return c;
        }
    }
}
