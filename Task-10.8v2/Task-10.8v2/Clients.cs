using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    public class Clients
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

        public Clients() { }

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

        public void AddNewClient()

        {
            Clients client = new Clients();

            Console.WriteLine("Введите фамилию сотрудника:");
            client.lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            client.firstName = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            client.patronymic = Console.ReadLine();

            Console.WriteLine("Введите номер телефона сотрудника в формате \"89991234567\":");
            if (long.TryParse(Console.ReadLine(), out long phone))
            {
                client.phone = phone;
            }

            Console.WriteLine("Введите серию и номер паспорта:");
            client.seriesAndNumberPasport = Console.ReadLine();

            listOfClients.Add(client);

            Console.WriteLine("Клиент успешно добавлен");
        }

        public static string ToString(Clients client)
        {

            return $"Фамилия {client.lastName}"
                          + $"\nИмя {client.firstName}"
                          + $"\nОтчество {client.patronymic}"
                          + $"\nТелефон {client.phone} "
                          + $"\nСерия и номер паспорта {GetSeriesAndNumberPasportFromeUser(client)}";
        }

        public static string GetSeriesAndNumberPasportFromeUser(Clients client)
        {
            return System.Text.RegularExpressions.Regex.Replace(client.seriesAndNumberPasport, @"\d", "*");
        }


    }
}
