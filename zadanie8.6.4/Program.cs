using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace zadanie8._6._4
{
    internal class Program
    {

        /// <summary>
        /// Метод сериализации PhoneBook
        /// </summary>
        /// <param name="СoncretePhoneBook">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static void SerializePhoneBook(PhoneBook СoncretePhoneBook, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));
            XElement myPerson = new XElement("Person");

            XElement myAddress = new XElement("Address");
            XElement myStreet = new XElement("Street");
            myStreet.Add(СoncretePhoneBook.Street);
            XElement myHouseNumber = new XElement("HouseNumber");
            myHouseNumber.Add(СoncretePhoneBook.HouseNumber);
            XElement myFlatNumber = new XElement("FlatNumber");
            myFlatNumber.Add(СoncretePhoneBook.FlatNumber);

            XElement myPhones = new XElement("Phones");
            XElement myMobilePhone = new XElement("MobilePhone");
            myMobilePhone.Add(СoncretePhoneBook.MobilePhone);
            XElement myFlatPhone = new XElement("FlatPhone");
            myFlatPhone.Add(СoncretePhoneBook.FlatPhone);

            XAttribute name = new XAttribute("name", СoncretePhoneBook.FIO);
            //XAttribute street = new XAttribute("street", СoncretePhoneBook.Street);
            //XAttribute houseNumber = new XAttribute("houseNumber", СoncretePhoneBook.HouseNumber);
            //XAttribute flatNumber = new XAttribute("flatNumber", СoncretePhoneBook.FlatNumber);
            //XAttribute mobilePhone = new XAttribute("mobilePhone", СoncretePhoneBook.MobilePhone);
            //XAttribute flatPhone = new XAttribute("flatPhone", СoncretePhoneBook.FlatPhone);

            myAddress.Add(myStreet, myHouseNumber, myFlatNumber);
            myPhones.Add(myMobilePhone, myFlatPhone);
            myPerson.Add(myAddress, myPhones, name);

            myPerson.Save(Path);

            //// Создаем поток для сохранения данных
            //Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            //// Запускаем процесс сериализации
            //xmlSerializer.Serialize(fStream, СoncretePhoneBook);

            //// Закрываем поток
            //fStream.Close();

            
        }
        /// <summary>
        /// Метод десериализации PhoneBook
        /// </summary>
        /// 
        /// <param name="Path">Путь к файлу</param>
        static void DeserializePhoneBook(string Path)
        {
            //PhoneBook tempPhoneBook = new PhoneBook();
            //// Создаем сериализатор на основе указанного типа 
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));

            //// Создаем поток для чтения данных
            //Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            //// Запускаем процесс десериализации
            //tempPhoneBook = xmlSerializer.Deserialize(fStream) as PhoneBook;

            //// Закрываем поток
            //fStream.Close();

            //// Возвращаем результат
            //return tempPhoneBook;

            string xml = System.IO.File.ReadAllText("_phone1.xml");

            var col = XDocument.Parse(xml)
                                .Descendants("Person")                                
                                .ToList();
            foreach (var item in col)
            {
                Console.WriteLine($"{item}");
            }

        }

        static void Main(string[] args)
        {
            #region Worker
            Console.WriteLine("Введите ФИО, Улица, Номер дома, Номер квартиры, Мобильный телефон, Домашний телефон");
            //string fio = Console.ReadLine();
            //string street = Console.ReadLine();
            //string houseNumber = Console.ReadLine();
            //string flatNumber = Console.ReadLine();
            //string mobilePhone = Console.ReadLine();
            //string flatPhone = Console.ReadLine();
            string fio = "Куршнев";
            string street = "Лукьяненко";
            string houseNumber = "10";
            string flatNumber = "31";
            string mobilePhone = "89064537";
            string flatPhone = "301-103";

            PhoneBook phoneBook = new PhoneBook(fio, street, houseNumber, flatNumber, mobilePhone, flatPhone);
            Console.WriteLine(phoneBook.Print());

            SerializePhoneBook(phoneBook, "_phone1.xml");

            Console.WriteLine("Сериализировали номер");
            Console.WriteLine();
            Console.WriteLine("Десериализируем номер");
            //phoneBook = DeserializePhoneBook("_phone1.xml");
            //Console.WriteLine(phoneBook.Print());
            //DeserializePhoneBook("_phone1.xml");
            DeserializePhoneBook("_phone1.xml");

            Console.ReadKey();
            #endregion
        }
    }
}
