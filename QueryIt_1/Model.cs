﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryIt_1
{
    public interface IEntity
    {
        bool IsValid();
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Employee : Person, IEntity
    {
        public int Id { get; set; }
        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }

        public bool IsValid()
        {
            return true;
        }
    }

    public class Manager : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine("Create a meeting");
        }
    }
}
