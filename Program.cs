using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ16.Linq2DB;

namespace DZ16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.ConnectionString);
            Linq2DB.Linq2DB.Demo();
        }
    }
}