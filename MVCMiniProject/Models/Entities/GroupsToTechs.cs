using System;
using System.Collections.Generic;

namespace MVCMiniProject.Models.Entities
{
    public partial class GroupsToTechs
    {
        public int GroupId { get; set; }
        public int TechId { get; set; }

        public Groups Group { get; set; }
        public Techs Tech { get; set; }
    }
}
