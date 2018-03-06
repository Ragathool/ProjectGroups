using System;
using System.Collections.Generic;

namespace MVCMiniProject.Models.Entities
{
    public partial class Groups
    {
        public Groups()
        {
            GroupsToTechs = new HashSet<GroupsToTechs>();
            Persons = new HashSet<Persons>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<GroupsToTechs> GroupsToTechs { get; set; }
        public ICollection<Persons> Persons { get; set; }
    }
}
