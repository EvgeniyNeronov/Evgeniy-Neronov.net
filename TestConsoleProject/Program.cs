using KosoyPerEntityDB;
using KosoyPerEntityDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            KosoiDataProvider dataProvider = new KosoiDataProvider();

            dataProvider.GetOrdersItemInfo().ForEach((line) => 
            {
                Console.WriteLine(line);
            });
        }
    }
}
