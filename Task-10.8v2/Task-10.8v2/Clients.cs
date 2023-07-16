namespace Task_10._8v2
{
    public class Clients
    {
        User user = new User();

        public Clients() { }

        /// <summary>
        /// Название фаила или "неявно указанный путь"
        /// </summary>
        string path = @"List of clients.txt";

        List<Client> clients = new List<Client>();

        /// <summary>
        /// Добавление нового клиента, все данные вводятся через консоль
        /// </summary>
        /// <returns>Возвращает строку успешной записи клиента</returns>
        public string AddNewClient()

        {
            Client client = new Client();

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

            if (!File.Exists(path))
            {

                File.WriteAllText(path, client.ToString());
            }
            else
            {
                string readFile = File.ReadAllText(path);

                List<string> listOfClients = File.ReadAllLines(path).ToList();

                listOfClients.Add(client.ToString());
            }
            return $"Клиент успешно добавлен в справочник";
        }

        public void AddNewClienOnlyPhoneNumber(long phone)
        {
            Client client = new Client(phone);
            clients.Add(client);
        }

        /// <summary>
        /// Возвращает коллекцию типа лист со всеми клиентами
        /// </summary>
        /// <returns>Возвращает коллекцию типа лист со всеми клиентами</returns>
        public List<string> GetAllClient()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Фаил не найден или список клиентов пуст");
                return new List<string>();
            }
            else
            {
                string readFile = File.ReadAllText(path);

                List<string> listOfClients = File.ReadAllLines(path).ToList();

                return listOfClients;
            }

        }

        /// <summary>
        /// Поиск клиента в фаила по фамилии. 
        /// Происходит чтение фаила по строкам
        /// Преобразование строк в объекты клиент и сравнение фамилии
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns>Если клиент найден, возвращает объект клиент из фаила, если нет, нового клиента </returns>
        public Client SearchClientForPhoneNumber(long phone)
        {
            Client returnClient = new Client();


            if (!File.Exists(path))
            {
                Console.WriteLine("Клиента нет в списке, создать нового?" +
                    "\n1 - Да" +
                    "\n2 - Нет");

                if(Console.ReadLine() == "1")
                {
                    AddNewClienOnlyPhoneNumber(phone);
                }
                else
                {
                    Console.WriteLine("Клиент не созда!");
                }
                return returnClient;
            }
            else
            {

                string readFile = File.ReadAllText(path);

                List<string> listOfClients = File.ReadAllLines(path).ToList();

                foreach (string textClient in listOfClients)
                {
                    Client client = ParsingTextInClient(textClient);

                    if(client.phone == phone)
                    {
                         returnClient = client;
                    }
                }

                return returnClient;
            }
        }

        /// <summary>
        /// Парсит текст в объект клиент
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Возвращает заполненный данными объект клиент</returns>
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

                if (!string.IsNullOrEmpty((string)parsingTextInWorker[0]))
                {
                    client.lastName = parsingTextInWorker[0];
                }

                if (!string.IsNullOrEmpty((string)parsingTextInWorker[1]))
                {
                    client.firstName = parsingTextInWorker[1];
                }

                if (!string.IsNullOrEmpty((string)parsingTextInWorker[2]))

                { 
                    client.patronymic = parsingTextInWorker[2];
                }

                if(long.TryParse(parsingTextInWorker[3], out long phoneNumber))
                {
                    client.phone = phoneNumber;
                }

                if (!string.IsNullOrEmpty((string)parsingTextInWorker[4]))
                {
                    client.seriesAndNumberPasport = parsingTextInWorker[4];

                }

                return client;
            }
        }

        public void PrintAllClientsFromUser()
        {
            GetAllClient();

            foreach(Client client in clients)
            {
                Console.WriteLine(user.ClientInfo(client));
            }
        }

        public void PrintAllClientsFromManager()
        {
            foreach(Client client in clients)
            {
                Console.WriteLine(value: client.ToString);
            }
        }
    }
}
