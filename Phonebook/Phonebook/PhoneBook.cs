using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Phonebook
{
    public class PhoneBook
    {
        List<Entry> entries;
        public PhoneBook()
        {
            entries = new List<Entry>();
        }

        public void AddContact()
        {
            Entry entry = new Entry();

            ShowColorText("Ввведите Имя:", ConsoleColor.DarkYellow);
            entry.Name = Console.ReadLine();

            ShowColorText("Ввведите Телефон:", ConsoleColor.DarkYellow);
            entry.PhoneNumber = Console.ReadLine();

            ShowColorText("Ввведите Адрес:", ConsoleColor.DarkYellow);
            entry.Adress = Console.ReadLine();

            entries.Add(entry);

            ShowColorText("Данные добавлены!", ConsoleColor.DarkGreen);
        }

        public void DisplayContacts()
        {
            ShowColorText("Контакты телефонной книги:", ConsoleColor.DarkYellow);

            for (int i = 0; i < entries.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + entries[i].ToString());
            }
        }

        public void FindContact(string Name)
        {
            ShowColorText("По вашему запросу " + Name + " найдено:", ConsoleColor.DarkYellow);

            for (int i = 0; i < entries.Count; i++)
            {
                if (entries[i].Name == Name)
                {
                    Console.WriteLine((i + 1) + "." + entries[i].ToString());
                }
            }
        }

        public void DeleteContact(string index)
        {
            try
            {
                entries.Remove(entries[int.Parse(index) - 1]);
                ShowColorText("Запись была удалена", ConsoleColor.DarkGreen);
            }
            catch (Exception)
            {
                ShowColorText("Такого индекса не существует", ConsoleColor.DarkRed);
            }
        }

        public void SaveContacts()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Entry>));

            using (FileStream fstream = new FileStream("contacts.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fstream, entries);
                ShowColorText("Контакты сохранены", ConsoleColor.DarkGreen);
            }
        }

        public void LoadContacts()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Entry>));

            using (FileStream fstream = new FileStream("contacts.xml", FileMode.Open))
            {
                try
                {
                    entries = (List<Entry>)xmlSerializer.Deserialize(fstream);
                    Console.WriteLine("Контакты загружены");
                }
                catch (Exception)
                {
                    Console.WriteLine("Телефонная книга пуста, либо повреждена");
                }
            }
        }

        public void ShowColorText(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
