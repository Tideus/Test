using System;

namespace Phonebook
{
   public class Program
    {      
        static void Main(string[] args)
        {
            Console.Title = "PhoneBook";
            Menu menu = new Menu();
            menu.LoadContacts();            
            menu.ShowMenu();         
        }      
    }
}
