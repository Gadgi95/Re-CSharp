using Task_10._8v2;

/* 
 * - Добавить функционал программы при запуске
 * 
 */

bool programExecution = true;

Client client = new Client();


Console.WriteLine("Добро пожаловать в справочник клиентов компании" +
    "\nВыберите пользователя:" +
    "\n1 - Менеджер" +
    "\n2 - Консультант");

string change = Console.ReadLine();

int.TryParse(change, out int changeNum);

switch (changeNum)
{
    case 1:
        Console.WriteLine("Вы вошли в  систему по пользователем \"Менеджер\"");

        Manager manager = new Manager();

        while (programExecution)
        {
            Console.WriteLine("Выберите действие:" +
                "\n1 - Вывести список клиентов" +
                "\n2 - Изменить номер телефона клиента" +
                "\n3 - Добавить фамилию клиента" +
                "\n4 - Добавить имя клиента" +
                "\n5 - Добавить отчество клиента" +
                "\n6 - Добавить серию и номер паспорта клиента" +
                "\n7 - Выход");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Client[] ArrayClient = client.GetAllClient();

                foreach(var clients in ArrayClient)
                {
                    Console.WriteLine(clients);
                }

            }
            else if (input == "2")
            {
                Console.WriteLine("Введите текущий телефон клиента, для изменения номера телефона:");

                string inputClientPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClientPhoneNumber) && long.TryParse(inputClientPhoneNumber, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    manager.SetPhoneNumber(clientChangePhoneNumber);
                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "3")

            {
                Console.WriteLine("Введите телефон клиента, для добавления фамилии:");

                string inputClientPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClientPhoneNumber) && long.TryParse(inputClientPhoneNumber, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    Console.WriteLine("Введите фамилию клиента:");

                    string newLastName = Console.ReadLine();

                    if(string.IsNullOrEmpty(newLastName))
                    {
                        Console.WriteLine("Введена пустая строка");
                    }
                    else
                    {
                        manager.AddClientLastName(phoneNumber, newLastName);

                    }
                   
                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("Введите телефон клиента, для добавления имени:");

                string inputClientPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClientPhoneNumber) && long.TryParse(inputClientPhoneNumber, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    Console.WriteLine("Введите имя клиента:");

                    string newFirstName = Console.ReadLine();

                    if (string.IsNullOrEmpty(newFirstName))
                    {
                        Console.WriteLine("Введена пустая строка");
                    }
                    else
                    {

                        manager.AddClientLastName(phoneNumber, newFirstName);

                    }

                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "5")
            {
                Console.WriteLine("Введите телефон клиента, для добавления имени:");

                string inputClientPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClientPhoneNumber) && long.TryParse(inputClientPhoneNumber, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    Console.WriteLine("Введите имя клиента:");

                    string newPatronymic = Console.ReadLine();

                    if (string.IsNullOrEmpty(newPatronymic))
                    {
                        Console.WriteLine("Введена пустая строка");
                    }
                    else
                    {
                        manager.AddClientLastName(phoneNumber, newPatronymic);

                    }

                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "6")
            {
                Console.WriteLine("Введите телефон клиента, для добавления серии и номера паспорта:");

                string inputClientPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClientPhoneNumber) && long.TryParse(inputClientPhoneNumber, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    Console.WriteLine("Введите серию и номер паспорта клиента:");

                    string newSeriesAndNumberPasport = Console.ReadLine();

                    if (string.IsNullOrEmpty(newSeriesAndNumberPasport))
                    {
                        Console.WriteLine("Введена пустая строка");
                    }
                    else
                    {
                        manager.AddClientLastName(phoneNumber, newSeriesAndNumberPasport);

                    }

                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "7")
            {
                programExecution = false;
                break;
            }

        }
        break;

    case 2:
        Console.WriteLine("Вы вошли в  систему по пользователем \"Консультант\"");
        Consultant consultant = new Consultant();

        while (programExecution)
        {
            Console.WriteLine("Выберите действие:" +
                "\n1 - Вывести список клиентов" +
                "\n2 - Изменить номер телефона клиента" +
                "\n3 - Выход");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Client[] ArrayClient = client.GetAllClient();

                foreach (var clients in ArrayClient)
                {
                    Console.WriteLine(consultant.GetClientInfo(client));
                }

            }
            else if (input == "2")
            {
                Console.WriteLine("Введите текущий номер клиента, для изменения номера телефона:");

                string inputClient = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputClient) && long.TryParse(inputClient, out long phoneNumber))
                {
                    Client clientChangePhoneNumber = client.SearchClientForPhone(phoneNumber);

                    Console.WriteLine("Введите новый номер клиента:");

                    string inputClientNewPhone = Console.ReadLine();

                    long.TryParse(inputClientNewPhone, out long newPhone);

                    clientChangePhoneNumber.Phone = newPhone;

                    consultant.SetPhoneNumber(clientChangePhoneNumber);
                }
                else
                {
                    Console.WriteLine("Введена пустая строка");
                }
            }
            else if (input == "3")
            {
                programExecution = false;
            }
        }
        break;

    default: Console.WriteLine("Введены неверные данные");
        break;
}

Console.ReadKey();










