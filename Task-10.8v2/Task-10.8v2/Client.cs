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
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Phone = phone;
            SeriesAndNumberPasport = seriesAndNumberPasport;
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
