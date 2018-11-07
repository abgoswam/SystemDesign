using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_1
{
    interface IEmployee
    {
        public string Name { get; set; }
        int Counter { get; }
    }

    public class Employee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Counter => throw new NotImplementedException();
    }
}
