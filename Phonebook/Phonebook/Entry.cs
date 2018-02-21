using System;

namespace Phonebook
{
    [Serializable]
    public class Entry
    {      
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public override string ToString()
        {
            return  Name + " " + PhoneNumber + " " + Adress;
        }
    }
}
