using System;

namespace Delegates
{
    class Program
    {
        public delegate void StringOp(string str);
        public static void PrintUpper(string str)
            {
                Console.WriteLine(str.ToUpper());
            }

        public static void PrintLower(string str)
            {
                Console.WriteLine(str.ToLower());
            }

        static void Main(string[] args)
        {
            
            StringOp stringOp = null;

            stringOp += PrintUpper;
            stringOp += PrintLower;

            Joiner jr = new Joiner("Nada");

            stringOp = jr.JoinAndPrint;

            stringOp.Invoke("Tudo");
        }
    }
}
