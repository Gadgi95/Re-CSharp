// Программа спрашивает у пользователя данные о контакте:
//ФИО
//Улица
//Номер дома
//Номер квартиры
//Мобильный телефон
//Домашний телефон
//С помощью XElement создайте xml файл, в котором есть введенная информация. XML файл должен содержать следующую структуру:
//< Person name =”ФИО человека” >
//    <Address>
//        <Street>Название улицы</Street>
//        <HouseNumber>Номер дома</HouseNumber>
//        <FlatNumber>Номер квартиры</FlatNumber>
//    </Address>
//    <Phones>
//        <MobilePhone>89999999999999</MobilePhone>
//        <FlatPhone>123-45-67<FlatPhone>
//    </Phones>
//</Person>


using System.IO;
using System.Xml.Linq;
using Task_8._6._4;

Console.WriteLine("Добро пожаловать в записную книжку");

List<Contact> contacts = new List<Contact>();

void AddNewContactToList()
{
    Contact contact = new Contact();

    Console.WriteLine("Введите ФИО сотрудника в формате \"Иванов Иван Иванович\":");
    contact.fullName = Console.ReadLine();

    Console.WriteLine("Введите улицу:");
    contact.street = Console.ReadLine();

    Console.WriteLine("Введите номер дома:");
    int.TryParse(Console.ReadLine(), out int houseNumber);
    contact.houseNumber = houseNumber;

    Console.WriteLine("Введите номер квартиры:");
    int.TryParse(Console.ReadLine(), out int flatNumber);
    contact.flatNumber = flatNumber;

    Console.WriteLine("Введите мобильный телефон:");
    long.TryParse(Console.ReadLine(), out long mobilePhoneNumber);
    contact.mobilePhoneNumber = mobilePhoneNumber;  

    Console.WriteLine("Введите домашний телефон:");
    int.TryParse(Console.ReadLine(), out int homePhoneNumber);
    contact.homePhoneNumber = homePhoneNumber;

    contacts.Add(contact);

    Console.WriteLine("Контакт создан");
}

XDocument xDocument = new XDocument();

void AddNewContactToXDoc()
{
    foreach (Contact contact in contacts)
    {
        XElement personXE = new XElement("person");
        XAttribute nameXE = new XAttribute("name", contact.fullName);

        XElement addressXE = new XElement("Address");

        XElement streetXE = new XElement("street", contact.street);
        XElement houseNumberXE = new XElement("HouseNumber", contact.houseNumber);
        XElement flatNumberXE = new XElement("FlatNumber", contact.flatNumber);

        XElement phonesXE = new XElement("phones");

        XElement mobilePhoneXE = new XElement("MobilePhone", contact.mobilePhoneNumber);
        XElement flatPhoneXE = new XElement("FlatPhone", contact.homePhoneNumber);

        addressXE.Add(streetXE, houseNumberXE, flatNumberXE);
        phonesXE.Add(mobilePhoneXE, flatPhoneXE);
        personXE.Add(nameXE, addressXE, phonesXE);

        xDocument.Add(personXE);
    }
    xDocument.Save("contacts.xml");
    Console.WriteLine("Контакт записан в документ");
}

AddNewContactToList();

AddNewContactToXDoc();

Console.ReadKey();


