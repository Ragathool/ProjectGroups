using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models.ViewModels
{
    public class GroupIndexVM
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string[] PersonName { get; set; }
        public string[] TechName { get; set; }
    }
}
