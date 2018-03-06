using System;
using System.Collections.Generic;

namespace MVCMiniProject.Models.Entities
{
    public partial class Techs
    {
        public Techs()
        {
            GroupsToTechs = new HashSet<GroupsToTechs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<GroupsToTechs> GroupsToTechs { get; set; }
    }
}
