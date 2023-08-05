using PhoneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Services.Interfaces
{
    internal interface IPersonService
    {
        void Create(Person person);
        List<Person> GetAll();
        bool Delete(string nameOrSurname);
    }
}
