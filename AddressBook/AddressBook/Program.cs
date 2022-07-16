using AddressBook;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Console.WriteLine("Welcome to Address Book Program in Address Book Main class on Master Branch");
Console.WriteLine("Press 1 to add contact Press 2 to edit contact Press 3 to delete contact");
Address obj = new Address();
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Enter the number of contacts needed to add");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the details to create a contact");
            obj.create();
        }
        Console.WriteLine("These are the contacts stored");
        obj.display();
        break;

    case 2:
        Console.WriteLine("Enter the first name of the contact you want to edit the details of");
        string Firstname = Console.ReadLine();
        Console.WriteLine("Enter the second name of the contact you want to edit the details of");
        string s_name = Console.ReadLine();
        obj.edit(Firstname, s_name);
        obj.display();
        break;
    case 3:
        Console.WriteLine("Enter the first name of the contact you want to delete the details of");
        string Firstname1 = Console.ReadLine();
        Console.WriteLine("Enter the second name of the contact you want to delete the details of");
        string s_name1 = Console.ReadLine();
        obj.delete(Firstname1, s_name1);
        break;
}