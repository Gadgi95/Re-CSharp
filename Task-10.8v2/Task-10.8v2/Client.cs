using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    public class Client
    {
        internal string lastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        internal string firstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        internal string patronymic
        {
            get { return this.patronymic; }
            set { this.patronymic = value; }
        }
        internal long phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        internal string seriesAndNumberPasport
        {
            get { return this.seriesAndNumberPasport; }
            set { this.seriesAndNumberPasport = value; }
        }
        internal List<Clients> listOfClients
        {
            get { return this.listOfClients; }
            set { this.listOfClients = value; }

        }

        public Client() { }

        public Client(long phone)
        {
            this.phone = phone;
        }

        public Client(
            string lastName,
            string firstName,
            string patronymic,
            long phone,
            string seriesAndNumberPasport)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.phone = phone;
            this.seriesAndNumberPasport = seriesAndNumberPasport;
        }

        public override string ToString()
        {
            return $"Фамилия {lastName}"
                          + $"#Имя {firstName}"
                          + $"#Отчество {patronymic}"
                          + $"#Телефон {phone}"
                          + $"#Серия и номер паспорта {seriesAndNumberPasport}";
        } 

    }
}
