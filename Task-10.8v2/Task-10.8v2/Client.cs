using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    public class Client
    {
        internal string LastName
        {
            get;
            set;
        }
        internal string FirstName
        {
            get;
            set;
        }
        internal string Patronymic
        {
            get;
            set;
        }
        internal long Phone
        {
            get;
            set;
        }
        internal string SeriesAndNumberPasport
        {
            get;
            set;
        }
        internal List<Clients> ListOfClients
        {
            get;
            set;

        }

        public Client() { }

        public Client(long phone)
        {
            this.Phone = phone;
        }

        public Client(
            string lastName,
            string firstName,
            string patronymic,
            long phone,
            string seriesAndNumberPasport)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.Phone = phone;
            this.SeriesAndNumberPasport = seriesAndNumberPasport;
        }

        public override string ToString()
        {
            return $"Фамилия {LastName}"
                          + $"#Имя {FirstName}"
                          + $"#Отчество {Patronymic}"
                          + $"#Телефон {Phone}"
                          + $"#Серия и номер паспорта {SeriesAndNumberPasport}";
        } 

    }
}
