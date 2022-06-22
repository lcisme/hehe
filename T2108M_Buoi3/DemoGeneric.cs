using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_Buoi3
{
    public class DemoGeneric<S,T>
    {
        public S Name { get; set; }
        public T Age { get; set; }

        public static void Main(string[] args)
        {
            DemoGeneric<string, int> d = new DemoGeneric<string, int>();
            d.Name = "Cuong dz";
            d.Age = 18;
        }
    }
}                                           