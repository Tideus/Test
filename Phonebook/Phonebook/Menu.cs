using System;

namespace Phonebook
{
    class Menu
    {
        PhoneBook phoneBook = new PhoneBook();
        ConsoleKeyInfo keyInfo;

        public void LoadContacts()
        {
            phoneBook.LoadContacts();
        }
        public void ShowMenu()
        {
            phoneBook.ShowColorText("Выберете на клавиатуре нужный пункт меню:" + "\n", ConsoleColor.DarkYellow);
            Console.WriteLine("1.Добавить контакт");
            Console.WriteLine("2.Вывести все контакты телефонной книги");
            Console.WriteLine("3.Найти контакт");
            Console.WriteLine("4.Удалить контакт");
            Console.WriteLine("5.Сохранить добавленные контакты");

            keyInfo = Console.ReadKey();
            Console.WriteLine();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1: phoneBook.AddContact(); break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2: phoneBook.DisplayContacts(); break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    {
                        phoneBook.ShowColorText("Введите имя:", ConsoleColor.DarkYellow);
                        phoneBook.FindContact(Console.ReadLine()); break;
                    }
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    {
                        phoneBook.ShowColorText("Введите индекс записи, которую нужно удалить", ConsoleColor.DarkYellow);
                        phoneBook.DeleteContact(Console.ReadLine()); break;
                    }
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5: phoneBook.SaveContacts(); break;
                default: phoneBook.ShowColorText("Неверная команда:", ConsoleColor.DarkRed); break;
            }

            Console.WriteLine(new string('-', 50));
            ShowMenu();
        }
    }
}
