using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8._6._4
{
    public class PhoneBook
    {
        #region Конструкторы

        public PhoneBook()
        {

        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="FIO">ФИО</param>
        /// <param name="Street">Улица</param>
        /// <param name="HouseNumber">Номер дома</param>
        /// <param name="FlatNumber">Номер квартиры</param>
        /// <param name="MobilePhone">Мобильный телефон</param>
        /// <param name="FlatPhone">Домашний телефон</param>
        public PhoneBook(string FIO, string Street, string HouseNumber, string FlatNumber, string MobilePhone, string FlatPhone)
        {
            this.fio = FIO;
            this.street = Street;
            this.houseNumber = HouseNumber;
            this.flatNumber = FlatNumber;
            this.mobilePhone = MobilePhone;
            this.flatPhone = FlatPhone;
        }

        #endregion

        #region Методы

        public string Print()
        {
            return $"{this.fio,15} {this.street,15} {this.houseNumber,15} {this.flatNumber,15} {this.mobilePhone,15} {this.flatPhone,15}";
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string FIO { get { return this.fio; } set { this.fio = value; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Street { get { return this.street; } set { this.street = value; } }

        /// <summary>
        /// Должность
        /// </summary>
        public string HouseNumber { get { return this.houseNumber; } set { this.houseNumber = value; } }

        /// <summary>
        /// Отдел
        /// </summary>
        public string FlatNumber { get { return this.flatNumber; } set { this.flatNumber = value; } }

        /// <summary>
        /// Оплата труда
        /// </summary>
        public string MobilePhone { get { return this.mobilePhone; } set { this.mobilePhone = value; } }

        /// <summary>
        /// Оплата труда
        /// </summary>
        public string FlatPhone { get { return this.flatPhone; } set { this.flatPhone = value; } }
               
        #endregion

        #region Поля

        /// <summary>
        /// Поле "ФИО"
        /// </summary>
        private string fio;

        /// <summary>
        /// Поле "Улица"
        /// </summary>
        private string street;

        /// <summary>
        /// Поле "Номер дома"
        /// </summary>
        private string houseNumber;

        /// <summary>
        /// Поле "Номер квартиры"
        /// </summary>
        private string flatNumber;

        /// <summary>
        /// Поле "Мобильный телефон"
        /// </summary>
        private string mobilePhone;

        /// <summary>
        /// Поле "Домашний телефон"
        /// </summary>
        private string flatPhone;

        #endregion
    }
}
