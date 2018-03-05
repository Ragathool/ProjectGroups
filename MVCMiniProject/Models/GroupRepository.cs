using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{
    public class GroupRepository
    {

        private static List<Group> GroupList = new List<Group>
        {
            new Group ("Grupp1", "Beskrivning", 1),
            new Group("Grupp2", "Beskrivning", 2),
            new Group("Grupp3", "Beskrivning", 3)
        };

        public List<Group> AddGroup(Group group)
        {
            GroupList.Add(group);
            return GroupList;
        }

        public Group[] GetAllGroups()
        {

            return GroupList.ToArray();
        }

        public Group GetGroupByID(int Id)
        {
            return GroupList
                .Single(b => b.Id == Id);
        }
    }
}
