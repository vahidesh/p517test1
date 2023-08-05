using PhoneApp.Data;
using PhoneApp.Models;
using PhoneApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Services
{
    internal class PersonService : IPersonService
    {
        private int _count = 1;
        public void Create(Person person)
        {
            person.Id = _count;
            AppDbContext.people.Add(person);
            _count++;
        }

        public bool Delete(string nameOrSurname)
        {
            //Other way
            ////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////
            // Person person = new();

            //foreach (var item in AppDbContext.people)
            // {
            //     if(item.Name == nameOrSurname || item.Surname == nameOrSurname)
            //     {
            //         person = item;
            //         break;
            //     }
            // }
            ////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////

            //Usable way
            var existPerson = AppDbContext.people.FirstOrDefault(m => m.Name == nameOrSurname || m.Surname == nameOrSurname);

            //var existPerson = AppDbContext.people.Where(m => m.Name == nameOrSurname || m.Surname == nameOrSurname).FirstOrDefault();

            if (existPerson != null)
            {
               AppDbContext.people.Remove(existPerson);
               return true;

            }

            return false;
            
        }

        public List<Person> GetAll()
        {
           return AppDbContext.people;
        }
    }
}
