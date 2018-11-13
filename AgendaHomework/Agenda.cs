using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AgendaHomework
{
    class Agenda
    {
        private List<Person> agendaList = new List<Person>();

        public void AddPerson() {
            Person pers;

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            int id = GetId();
            pers = new Person(id, firstName, lastName);
            agendaList.Add(pers);
        }

        public int GetId()
        {
             return agendaList.Count + 1;
        }

        public void GetPerson()
        {
            foreach (Person p in agendaList)
            {
                Console.WriteLine(p.Id + " " + p.FirstName + " " + p.LastName);
            }
        }

        public void SortAgenda()
        {
            string sortType;
            Console.WriteLine("Sort by: 1.Name or 2.Id ?");
            sortType = Console.ReadLine();
            if(sortType=="1") agendaList.Sort();
            if (sortType == "2") agendaList.OrderBy(pers => pers.Id);

            GetPerson();
        }
        public void SortById()
        {
            agendaList.OrderBy(pers => pers.Id);
            GetPerson();
        }

    }
}
