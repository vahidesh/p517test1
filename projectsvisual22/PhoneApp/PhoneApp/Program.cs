
using PhoneApp.Controllers;
using PhoneApp.Data;
using PhoneApp.Enums;
using PhoneApp.Models;

Menues();

PersonController personController = new(); 

while (true)
{
    Operation: string operation = Console.ReadLine();

    int option;

    bool isTrueOption = int.TryParse(operation, out option);

    if (isTrueOption)
    {
        switch (option)
        {
            case (int)Operations.Create:
                personController.Create();
                break;
            case (int)Operations.Delete:
                personController.Delete();
                break;
            case (int)Operations.Edit:
                Console.WriteLine("Editted");
                break;
            case (int)Operations.GetAll:
                personController.GetAll();
                break;
            case (int)Operations.Search:
                Console.WriteLine("Searched");
                break;
            default:
                Console.WriteLine("Option is wrong, please select true option again");
                goto Operation;
               
        }
    }
    else
    {
        Console.WriteLine("Option is wrong, please try again : ");

        goto Operation;
    }


    
}



static void Menues()
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \r\n  *************** (1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak");
}