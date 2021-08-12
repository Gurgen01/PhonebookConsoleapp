using System;

namespace PhonebookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Phonebook console application");
            Console.WriteLine("Select operation");
            Console.WriteLine("1-Add contact");
            Console.WriteLine("2-Display contact by number");
            Console.WriteLine("3-View all contacts");
            Console.WriteLine("4-Search for contacts for a given name");
            Console.WriteLine("5-Delete contact by number");
            Console.WriteLine("6-Press x to exit");
            
            var phonebook = new Phonebook();
            while (true)
            {
                Console.WriteLine("Select operation");
                var userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();
                        phonebook.Add(new Contact(name, number));
                        break;
                    case "2":
                        Console.WriteLine("Contact number:");
                        phonebook.DisplayContact(Console.ReadLine());
                        break;
                    case "3":
                        phonebook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Contact name:");
                        var input = Console.ReadLine();
                        phonebook.DisplayMatchingContacts(input);
                        break;
                    case "5":
                        Console.WriteLine("Contact number:");
                        phonebook.DeleteContact(Console.ReadLine());
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;

                }

            }
        }
    }
}
