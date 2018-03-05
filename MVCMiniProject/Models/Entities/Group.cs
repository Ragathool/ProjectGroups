using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{


    public class Group
    {
        public Group(string name, string description, int id)
        {
            Id = Id;
            Name = name;
            Description = description;
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
