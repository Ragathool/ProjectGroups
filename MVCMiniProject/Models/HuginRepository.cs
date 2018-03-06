using MVCMiniProject.Models.Entities;
using MVCMiniProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{
    public class HuginRepository
    {
        private readonly HuginContext context;

        public HuginRepository(HuginContext context)
        {
            this.context = context;
        }

        internal GroupIndexVM[] GetAllGroups()
        {
            var q = context.Groups.Select // DB.DBset.Select
                    (g => new GroupIndexVM
                    {
                        GroupName = g.Name,
                        Description = g.Description,
                        GroupPersons = g.Persons.Select(gp => new GroupPersonVM { Name = gp.Name }).ToArray(),
                        GroupTechs = g.GroupsToTechs .Select(gt => new GroupTechVM { Name = gt.Tech.Name }).ToArray()
                    })
                    .OrderBy(g => g.GroupName)
                    .ToArray();

            return q;
        }

        internal GroupCreateVM[] PrintGroupForm()
        {
            var q = context.Groups.Select // DB.DBset.Select
                    (g => new GroupCreateVM
                    {
                        GroupName = g.Name,
                        Description = g.Description,
                        GroupPersons = g.Persons.Select(gp => new GroupPersonVM { Name = gp.Name }).ToArray(),
                        GroupTechs = g.GroupsToTechs.Select(gt => new GroupTechVM { Name = gt.Tech.Name }).ToArray()
                    })
                    //.OrderBy(g => g.GroupName)
                    .ToArray();

            return q;
        }
    }
}
