using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMiniProject.Models
{
    public class PersonRepository
    {
        private static List<Person> PersonList = new List<Person>
        {
            new Person ("Andreas", 1),
            new Person("Dick", 2),
            new Person("Cathrine", 3)
        };

        public List<Person> Addperson(Person group)
        {
            PersonList.Add(group);
            return PersonList;
        }

        public Person[] GetAllPersons()
        {

            return PersonList.ToArray();
        }

        public Person GetGroupByID(int Id)
        {
            return PersonList
                .Single(b => b.Id == Id);
        }
    }
}
