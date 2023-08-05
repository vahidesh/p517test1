using PhoneApp.Data;
using PhoneApp.Models;
using PhoneApp.Services;
using PhoneApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _service;

        public PersonController()
        {
            _service = new PersonService();
        }
        public void Create()
        {
            Console.WriteLine("Add name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Add surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Add phone number: ");
            string phoneNumber = Console.ReadLine();

            Person person = new()
            {          
                Name = name,
                Surname = surname,
                Phone = phoneNumber
            };

            _service.Create(person);

            Console.WriteLine("Person add operation is successful");
        }

        public void GetAll()
        {
           

            foreach (var item in _service.GetAll())
            {
                string data = $"Id: {item.Id}, Fullname : {item.Name} {item.Surname}, Phone : {item.Phone}";
                Console.WriteLine(data);
            }
        }


        public void Delete()
        {
            Console.WriteLine("Please enter the name or surname of the person that you want to delete his/her number: ");

            NameOrSurname:  string nameOrSurname = Console.ReadLine();

            if (string.IsNullOrEmpty(nameOrSurname.Trim()))
            {
                Console.WriteLine("Can not be empty, please try again: ");
                goto NameOrSurname;
            }

            bool result = _service.Delete(nameOrSurname);

           

            if (!result)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n  * Silmeyi sonlandırmak için : (1)\r\n  * Yeniden denemek için      : (2)");

               Option: string option = Console.ReadLine();

                int selectedOption;

                bool isTrueOption = int.TryParse(option, out selectedOption);

                if (isTrueOption)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \r\n  *************** (1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak");
                            break;
                            case 2:
                            Console.WriteLine("Try again for delete:");
                            goto NameOrSurname;
                        default:
                            Console.WriteLine("Try again for option:");
                            goto Option;
                            
                    }
                }
                else
                {
                    Console.WriteLine("Select option again");
                    goto Option;
                }
              
            }
            else
            {
                Console.WriteLine("Delete is successful");
            }



        }


    }
}
