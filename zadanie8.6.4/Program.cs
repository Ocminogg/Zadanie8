using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace zadanie8._6._4
{
    internal class Program
    {
        
        /// <summary>
        /// Метод сериализации Worker
        /// </summary>
        /// <param name="СoncretePhoneBook">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static void SerializePhoneBook(PhoneBook СoncretePhoneBook, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации
            xmlSerializer.Serialize(fStream, СoncretePhoneBook);

            // Закрываем поток
            fStream.Close();
        }
        /// <summary>
        /// Метод десериализации Worker
        /// </summary>
        /// 
        /// <param name="Path">Путь к файлу</param>
        static PhoneBook DeserializePhoneBook(string Path)
        {
            PhoneBook tempPhoneBook = new PhoneBook();
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            tempPhoneBook = xmlSerializer.Deserialize(fStream) as PhoneBook;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
            return tempPhoneBook;
        }

        static void Main(string[] args)
        {
            #region Worker
            Console.WriteLine("Введите ФИО, Улица, Номер дома, Номер квартиры, Мобильный телефон, Домашний телефон");
            string fio = Console.ReadLine();
            string street = Console.ReadLine();
            string houseNumber = Console.ReadLine();
            string flatNumber = Console.ReadLine();
            string mobilePhone = Console.ReadLine();
            string flatPhone = Console.ReadLine();

            PhoneBook phoneBook = new PhoneBook(fio, street, houseNumber, flatNumber, mobilePhone, flatPhone);
            Console.WriteLine(phoneBook.Print());

            SerializePhoneBook(phoneBook, "_phone1.xml");

            Console.WriteLine("Сериализировали номер");
            Console.WriteLine();
            Console.WriteLine("Десериализируем номер");
            phoneBook = DeserializePhoneBook("_phone1.xml");
            Console.WriteLine(phoneBook.Print());
            Console.ReadKey();
            #endregion
        }
    }
}
