using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaHomework
{
    class UserInterface
    {
        public void Run()
        {
            Agenda agenda = new Agenda();
            while (true)
            {
               
                Console.WriteLine(" 1. Add a person to the agenda.");
                Console.WriteLine(" 2. Display agenda.");
                Console.WriteLine(" 3. Sort agenda.");
                Console.WriteLine(" X. Exit.");
                Console.Write(" Please select an operation: ");

                string selection;
                selection = Console.ReadLine();
                if (selection == "1") agenda.AddPerson();
                if (selection == "2") agenda.GetPerson();
                if (selection == "3") agenda.SortAgenda();
                if (selection.ToLower() == "x") return;

            }
        }
    }
}
