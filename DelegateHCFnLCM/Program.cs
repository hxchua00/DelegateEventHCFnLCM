using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHCFnLCM
{
    public delegate void MathOpsEventHandler(int x, int y);
    class Program
    {
        public static event MathOpsEventHandler MathOps;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            HCFnLCM result = new HCFnLCM(x, y);
            MathOps += result.findHCFnLCM;
            MathOps.Invoke(x, y);


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
