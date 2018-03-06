using System;
using System.Collections.Generic;

namespace MVCMiniProject.Models.Entities
{
    public partial class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public Groups Group { get; set; }
    }
}
