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
            this.LastName = "Данные не заполнены";
            this.FirstName = "Данные не заполнены";
            this.Patronymic = "Данные не заполнены";
            this.Phone = phone;
            this.SeriesAndNumberPasport = "Данные не заполнены";
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

        string path = @"List of clients.txt";

        public void WriteClientInFile(Client client)  ///Добавить метод записи массива клиентов в текстовый фаил
        {  
            if (client == null) 
            { 
                return; 
            }
            if(!File.Exists(path))
            {
                File.WriteAllText(path, ParsingClientInText(client));
            }
            else
            {
                string readFile = File.ReadAllText(path); // Путь к фаилу

                string[] arrayReadFile = readFile.Split('\n'); //Создание и заполнение массива строками из фаила

                string[] reArrayFileClients = new string[arrayReadFile.Length + 1];

                for (int i = 0; i < arrayReadFile.Length; i++)
                {
                    reArrayFileClients[i] = arrayReadFile[i];
                }

                reArrayFileClients[reArrayFileClients.Length - 1] = ParsingClientInText(client);

                File.WriteAllLines(path, reArrayFileClients);


            }

        }

        public Client[] GetAllClient() ///Добавить метод чтения фаила в массив клиентов
        {
            if (!File.Exists(path) || string.IsNullOrEmpty(File.ReadAllText(path)))
            {
                Console.WriteLine("Список клиентов пуст");
                return new Client[0];
            }

            else
            {
                string readFile = File.ReadAllText(path); // Путь к фаилу

                string[] arrayReadFile = readFile.Split(Environment.NewLine); //Создание и заполнение массива строками из фаила

                Client[] clients = new Client[arrayReadFile.Length];

                for (int i = 0; i <= arrayReadFile.Length - 1; i++)
                {
                    clients[i] = ParsingTextInClient(arrayReadFile[i]);
                }

                return clients;
            }
        }

        public Client ParsingTextInClient(string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return new Client();
            }
            else
            {
                string[] parsingTextInWorker = text.Split('#');

                Client client = new Client();

                client.LastName = parsingTextInWorker[0];

                client.FirstName = parsingTextInWorker[1];

                client.Patronymic = parsingTextInWorker[2];

                if(long.TryParse(parsingTextInWorker[3], out long clientPhone))
                {
                    client.Phone = clientPhone;

                }

                client.SeriesAndNumberPasport = parsingTextInWorker[4];

                return client;
            }

        }

        public string ParsingClientInText(Client client)
        {
            return $"{client.LastName}#{client.FirstName}#{client.Patronymic}#{client.Phone}#{client.SeriesAndNumberPasport}";
        }

        public Client SearchClientForPhone(long phone)
        {
            Client[] clients = GetAllClient();

            Client searchingClient = new Client();

            foreach (Client client in clients)
            {
                if(client.Phone != phone)
                {
                    continue;
                }
                else
                {
                    searchingClient = client;
                }
            }
            return searchingClient;

        }
    }
}
