using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> testList = new GenericList<int>();

            testList.Add(1); //tested my .add to make sure it was actually adding a bigger array
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            Console.ReadLine();
        }
    }
}
