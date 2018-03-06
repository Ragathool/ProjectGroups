using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models.ViewModels
{


    public class GroupCreateVM
    {
        public GroupPersonVM[] GroupPersons { get; set; }
        public GroupTechVM[] GroupTechs { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}
