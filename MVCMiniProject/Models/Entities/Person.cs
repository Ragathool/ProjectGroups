using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{
    public class Person
    {
        public Person(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
