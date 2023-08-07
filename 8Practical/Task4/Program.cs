using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XAttribute name = new XAttribute("name","ФИО");
            XElement person = new XElement("Person");
            person.Add(name);
            XElement address = new XElement("Address");
            XElement street = new XElement("Street","Улица");
            XElement houseNumber = new XElement("HouseNumber","№25");
            XElement flatNumber = new XElement("FlatNumber", "№54");
            address.Add(street,houseNumber,flatNumber);
            XElement phones = new XElement("Phones");
            XElement mobilePhone = new XElement("MobilePhone", "8 (903) 727-57-44");
            XElement flatPhone = new XElement("FlatPhone", "8 (495) 818-22-35");
            phones.Add(mobilePhone,flatPhone);
            person.Add(address,phones);
            Stream stream = new FileStream("Person.xml", FileMode.OpenOrCreate,FileAccess.Write);
            person.Save(stream);
            stream.Close();
        }
    }
}
