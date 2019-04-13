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
            GenericList<string> animal = new GenericList<string>();

            animal.Add("Dog"); //tested my .add to make sure it was actually adding a bigger array
            animal.Add("Cat"); //tested my .remove to make sure it was actually
            animal.Add("Frog");
            animal.Add("Fish");
            animal.Remove("Dog");
        }
    }
}
