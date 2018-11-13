using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaHomework
{
    class Person: IComparable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int CompareTo(Person prs)
        {
            return this.FirstName.CompareTo(prs.FirstName);
        }

        public int CompareToId(Person prs)
        {
            return this.Id.CompareTo(prs.Id);
        }
    }
}
