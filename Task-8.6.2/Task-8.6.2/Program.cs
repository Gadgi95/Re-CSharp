//1. Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
//
//2. В процессе ввода информация размещается в Dictionary,
//где ключом является номер телефона, а значением — ФИО владельца.
//Таким образом, у одного владельца может быть несколько номеров телефонов.
//Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
//
//3. Далее программа предлагает найти владельца по введенному номеру телефона.
//Пользователь вводит номер телефона и ему выдаётся ФИО владельца.
//Если владельца по такому номеру телефона не зарегистрировано, программа выводит на экран соответствующее сообщение.

Console.WriteLine("Добро пожаловать в телефонный справочник!");

Dictionary<long, string> phonebook = new Dictionary<long, string>();


void AddAllContacts()
{
    while (true)
    {
        Console.WriteLine("Введите номер телефона в формате \"89991234567\" для записи: ");

        string inputPhoneNumber = Console.ReadLine();

        if (inputPhoneNumber == null || inputPhoneNumber == "")
        {
            break;
        }

        long.TryParse(inputPhoneNumber, out long phoneNumber);

        Console.WriteLine("Введите имя контакта: ");

        string inputContactName = Console.ReadLine();

        if (inputContactName == null || inputContactName == "")
        {
            break;
        }

        phonebook.Add(phoneNumber, inputContactName);
    }
}

void SearchContact()
{
    Console.WriteLine("Введите номер телефона в формате \"89991234567\" для поиска контакта");

    string inputPhoneNumber = Console.ReadLine();

    long.TryParse(inputPhoneNumber, out long phoneNumber);

    foreach (KeyValuePair<long, string> e in phonebook)
    {

        if (phoneNumber == e.Key)
        {
            Console.WriteLine($"Номер телефона найден у контакта: {e.Value}");
            return;
        }

        else
        {
            Console.WriteLine("Контакт не найден");
            Console.WriteLine("Введите имя контакта, для добавление номера в справочник");

            string inputName = Console.ReadLine();

            if(inputName == null || inputName == "")
            {
                return;
            }

            phonebook.Add(phoneNumber, inputName);

        }
    }
}

AddAllContacts();
SearchContact();

Console.ReadKey();



