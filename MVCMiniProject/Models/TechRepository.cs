using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{
    public class TechRepository
    {
        private static List<Tech> TechList = new List<Tech>
        {
            new Tech ("MVC"),
            new Tech("SQL"),
            new Tech("C#")
        };

        public List<Tech> AddTech (Tech tech)
        {
            TechList.Add(tech);
            return TechList;
        }

        public Tech[] GetAllTech()
        {

            return TechList.ToArray();
        }

        public Tech GetTechByID(int Id)
        {
            return TechList
                .Single(b => b.Id == Id);
        }
    }
}

