using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args) {
            testEntities te = new testEntities();
            te.t1.ToList().ForEach(p => Console.Write(p.id.ToString(), p.c1));
            Console.ReadKey();
        }
    }
}
