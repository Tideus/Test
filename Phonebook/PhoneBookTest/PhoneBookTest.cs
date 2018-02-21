using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook;

namespace PhoneBookTest
{
    [TestClass]
    public class PhoneBookTest
    {

        [TestMethod]
        public void AddContactTest()
        {
            PhoneBook book = new PhoneBook();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("Михаил{0}404571{0}Зеленый Лог 15{0}",
                    Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    book.AddContact();

                    string expected = string.Format("Ввведите Имя:{0}Ввведите Телефон:{0}Ввведите Адрес:{0}Данные добавлены!{0}", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }
    }
}



