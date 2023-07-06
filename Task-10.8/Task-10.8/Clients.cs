using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8
{
    public class Clients
    {

        internal string lastName
        {
            get => lastName;
            set => lastName = string.IsNullOrEmpty(value) ? value : throw new Exception("Указана пустая строка");
            
        }
        internal string firstName
        {
            get => firstName;
            set => firstName = string.IsNullOrEmpty(value) ? value : throw new Exception("Указана пустая строка");
        }
        internal string patronymic
        {
            get => patronymic;
            set => patronymic = string.IsNullOrEmpty(value) ? value : throw new Exception("Указана пустая строка");
        }
        internal long phone {
            get => phone;
            set => phone = value.ToString().Length <= 0 ? value : throw new Exception("Номер телефона пуст");
        }
        internal string seriesAndNumberPasport
        {
            get => seriesAndNumberPasport;
            set => seriesAndNumberPasport = value.ToString().Length <= 0 ? value : throw new Exception("Серия и номер паспорта пустые");
        }

        public Clients() {}

        public Clients(
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

        public static ObservableCollection<Clients> clientsList = new ObservableCollection<Clients>();

        public static ObservableCollection<Clients> GetClientsList()
        {
            return clientsList;
        }

        public static void AddNewClient()

        {
            Clients client = new Clients();

            Console.WriteLine("Введите фамилию сотрудника:");
            client.lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            client.firstName = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            client.patronymic = Console.ReadLine();

            Console.WriteLine("Введите номер телефона сотрудника:");
            if(long.TryParse(Console.ReadLine(), out long phone))
            {
                client.phone = phone;
            }

            Console.WriteLine("Введите серию и номер паспорта:");
            client.seriesAndNumberPasport = Console.ReadLine();

            clientsList.Add(client);

            Console.WriteLine("Сотрудник внесен в базу");
        }

        public static string ToString(Clients client)
        {

            return $"Фамилия {client.lastName}"
                          + $"\n Имя {client.firstName}"
                          + $"\nОтчество {client.patronymic}"
                          + $"\n Телефон {client.phone} ";        
        }

        public static string GetSeriesAndNumberPasportFromeUser(Clients client)
        {
            return System.Text.RegularExpressions.Regex.Replace(client.seriesAndNumberPasport, @"\d", "*");
        }

        
    }
}
