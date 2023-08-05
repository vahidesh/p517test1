using PhoneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Data
{
    internal static class AppDbContext
    {
        public static List<Person> people;

        static AppDbContext()
        {
            people = new List<Person>();
        }
    }
}
