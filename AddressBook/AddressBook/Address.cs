
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Addressbook
{
    public class addressBook
    {
        List<contact> add_book = new List<contact>();          //created an address book list of contact class type
        public void create()
        {
            int ch = 1;                                     //for choice of more contacts adding ....initially adds a contact
            do
            {
                contact Contact = new contact();                    //created an object of the Contact class and added contact details
                Console.WriteLine("Enter your first name");
                Contact.first_name = Console.ReadLine();
                Console.WriteLine("Enter your second name");
                Contact.s_name = Console.ReadLine();
                Console.WriteLine("Enter your address");
                Contact.address = Console.ReadLine();
                Console.WriteLine("Enter your city");
                Contact.city = Console.ReadLine();
                Console.WriteLine("Enter your state");
                Contact.state = Console.ReadLine();
                Console.WriteLine("Enter your zip code");
                Contact.zip = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your phone number");
                Contact.phone_no = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your email");
                Contact.email = Console.ReadLine();
                add_book.Add(Contact);
                Console.WriteLine("Enter 1 - for adding more contacts and 2 - for exiting");
                ch = Convert.ToInt16(Console.ReadLine());
            } while (ch == 1);
        }
        public void edit(String Fname, String Sname) //Editing a contact
        {
            contact Contact = new contact();
            foreach (var person in add_book)
            {
                if (person.first_name.Equals(Fname) && person.s_name.Equals(Sname))
                {
                    Console.WriteLine("Edit and confirm the details now -");
                    Console.WriteLine("Enter your first name");
                    person.first_name = Console.ReadLine();
                    Console.WriteLine("Enter your second name");
                    person.s_name = Console.ReadLine();
                    Console.WriteLine("Enter your address");
                    person.address = Console.ReadLine();
                    Console.WriteLine("Enter your city");
                    person.city = Console.ReadLine();
                    Console.WriteLine("Enter your state");
                    person.state = Console.ReadLine();
                    Console.WriteLine("Enter your zip code");
                    person.zip = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter your phone number");
                    person.phone_no = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter your email");
                    person.email = Console.ReadLine();
                    Console.WriteLine();
                }
            }
        }
        public void delete(String Fname, String Sname)
        {
            contact Contact = new contact();
            bool found = false;
            foreach (var person in add_book)
            {
                if (person.first_name.Equals(Fname) && person.s_name.Equals(Sname))
                {
                    found = true;
                    add_book.Remove(person);
                    Console.WriteLine("Contact deleted");
                }
            }
            if (found == false)
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void display()               //displaying details of each conatact
        {
            foreach (var data in add_book)
            {
                Console.WriteLine("Contact Name. - " + data.first_name);
                Console.WriteLine("Full Name - " + data.first_name + " " + data.s_name);
                Console.WriteLine("Address - " + data.address);
                Console.WriteLine("City- " + data.city);
                Console.WriteLine("State - " + data.state);
                Console.WriteLine("Zip - " + data.zip);
                Console.WriteLine("Phone no. - " + data.phone_no);
                Console.WriteLine("Email - " + data.email);
                Console.WriteLine();
            }
        }
    }
}

