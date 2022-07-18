using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    internal class CHOICE
    {
        public static void Choice(int ch, addressBook obj)
        {
            int choice = ch;
            if (choice != 5)
            {
                //addressBook obj = new addressBook();
                do
                {
                    if (choice == 1)
                    {
                        obj.create();
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Enter the first name");
                        string Fname = Console.ReadLine();
                        Console.WriteLine("Enter the second name");
                        string Sname = Console.ReadLine();
                        obj.edit(Fname, Sname);
                    }
                    if (choice == 3)
                    {
                        Console.WriteLine("Enter the first name");
                        string Fname = Console.ReadLine();
                        Console.WriteLine("Enter the second name");
                        string Sname = Console.ReadLine();
                        obj.delete(Fname, Sname);
                    }
                    if (choice == 4)
                    {
                        obj.display();
                    }
                    Console.WriteLine("Enter your choice");                         //So that we check the user's choice again
                    Console.WriteLine("1 - for adding contacts");
                    Console.WriteLine("2 - for editing a contact");
                    Console.WriteLine("3 - for deleting a contact ");
                    Console.WriteLine("4 - for displaying the list stored in addressbook a contact ");
                    Console.WriteLine("5 - exiting the program ");
                    choice = Convert.ToInt16(Console.ReadLine());
                } while (choice > 0 && choice < 5);
            }
        }
    }
}
