using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_1
{
    class NamedTuple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abhishek Goswami");

            var unnamed = ("one", "two");
            Console.WriteLine("{0}:{1}", unnamed.Item1, unnamed.Item2);


            var named = (first: "one 1", second: "two 2");
            Console.WriteLine("{0}:{1}", named.first, named.second);

            List<(int id, string name)> idNames1 = new List<(int, string)>();
            idNames1.Add((1, "aj"));
            idNames1.Add((2, "yog"));
            foreach (var item in idNames1)
            {
                Console.WriteLine("id:{0}, name:{1}", item.id, item.name);
            }

            List<(int id, string name)> idNames2 = new List<(int, string)>();
            idNames2.Add((1, "aj2"));
            idNames2.Add((2, "yog2"));
            foreach (var item in idNames2)
            {
                Console.WriteLine("id:{0}, name:{1}", item.id, item.name);
            }

            var deptPeople = new Dictionary<int, List<(int id, string name)>>() {
                {111, idNames1},
                {222, idNames2}
            };

            var retrieve = deptPeople[111];
            foreach (var item in retrieve)
            {
                Console.WriteLine("id:{0}, name:{1}", item.id, item.name);
            }
        }
    }
}
