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
            get => lastName;
            set => lastName = value;
        }
        internal string firstName
        {
            get => firstName;
            set => firstName = value;
        }
        internal string patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }
        internal long phone
        {
            get => phone;
            set => phone = value;
        }
        internal string seriesAndNumberPasport
        {
            get => seriesAndNumberPasport;
            set => seriesAndNumberPasport = value;
        }
        internal List<Clients> listOfClients
        {
            get => listOfClients;
            set => listOfClients = value;

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
