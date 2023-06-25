////Создайте справочник «Сотрудники».
//Разработайте для предполагаемой компании программу, которая будет добавлять записи новых сотрудников в файл. Файл должен содержать следующие данные:
//ID
//Дату и время добавления записи
//Ф. И. О.
//Возраст
//Рост
//Дату рождения
//Место рождения
//Для этого необходим ввод данных с клавиатуры. После ввода данных:
//если файла не существует, его необходимо создать;
//если файл существует, то необходимо записать данные сотрудника в конец файла. 
//При запуске программы должен быть выбор:
//введём 1 — вывести данные на экран;
//введём 2 — заполнить данные и добавить новую запись в конец файла.
//Файл должен иметь следующую структуру:
//1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва
//2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск

using System.Runtime.CompilerServices;

string path = @"C:\Users\user\Desktop\C#\skillbox\CSharp\Task-6.6\Employee Handbook.txt";

var consoleText = string.Format(
    "Добро пожаловать в справочник{0}" +
    "1 - вывести справочник на экран{0}" +
    "2 - заполнить данные и добавить новую запись{0}", Environment.NewLine);
Console.WriteLine(consoleText);

string readLine = Console.ReadLine();

if(String.IsNullOrEmpty(readLine))
{
    Console.WriteLine("Введена пустая строка");
    Console.ReadKey();
    return;
}

if(!int.TryParse(readLine, out var valueReadLine))
{
    Console.WriteLine("Введено не число!");
    Console.ReadKey();
}

if(valueReadLine == 1 )
{
    if(File.Exists(path))
    {
        string readFile = File.ReadAllText(path);
        string[] arrayReadFile = readFile.Split('#');
        foreach(string str in arrayReadFile)
        {
            Console.Write(str + " ");
        }
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("Фаил не найден");
        Console.ReadKey();
    }
}
else if(valueReadLine == 2 )
{
    addNewEmployee();
}
else
{
    Console.WriteLine("Введены не верные данные!");
    Console.ReadKey();
    return;
}

string userInputNewEmployee()
 
{
    DateTime dateTimeAddedTheEntry = DateTime.Now;

    Console.WriteLine("Введите ФИО сотрудника в формате \"Иванов Иван Иванович\":");
    string fullName = Console.ReadLine();

    Console.WriteLine("Введите возраст сотрудника:");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите рост сотрудника:");
    int height = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите дату рождения сотрудника в формате дд.мм.гггг:");
    DateTime birthDay = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Введите место рождения сотрудника:");
    string placeOfBirth = Console.ReadLine();

    return $"#{dateTimeAddedTheEntry}#{fullName}#{age}#{height}#{birthDay}#{placeOfBirth}";
}

void addNewEmployee()
{
    if (!File.Exists(path))
    {
        File.WriteAllText(path, "1" + userInputNewEmployee());
    }

    string[] arrayFileEmployee = File.ReadAllLines(path);

    string newEmployee = (arrayFileEmployee.Length + 1) + userInputNewEmployee();

    string[] reArrayFileEmployee = new string[arrayFileEmployee.Length + 1];

    for (int i = 0; i < arrayFileEmployee.Length; i++)
    {
            reArrayFileEmployee[i] = arrayFileEmployee[i];
    }

    reArrayFileEmployee[reArrayFileEmployee.Length - 1] = newEmployee;

    File.WriteAllLines(path, reArrayFileEmployee);
    
    
}


//Задание 7.8
//Создайте класс Repository, который будет отвечать за работу с экземплярами Worker.
//В репозитории должны быть реализованы следующие функции:
//Просмотр всех записей.
//Просмотр одной записи. Функция должна на вход принимать параметр ID записи, которую необходимо вывести на экран. 
//Создание записи.
//Удаление записи.
//Загрузка записей в выбранном диапазоне дат.

//public class Repository
//{
//    public struct Worker
//    {
//        public int Id { get; set; }
//        public DateTime dateTimeAddedTheEntry { get; set; }
//        public string fullName { get; set; }
//        int age { get; set; }
//        int height { get; set; }
//        DateTime birthDay { get; set; }
//        string placeOfBirth { get; set; }
//    }

//    public Worker[] GetAllWorkers()
//    {
//        if (File.Exists( " " )) // Добавить путь к фаилу
//        {
//            string readFile = File.ReadAllText(" "); // Путь к фаилу
//            string[] arrayReadWords = readFile.Split('#'); // Разбили текст на массив слов
//            string[] arrayReadFile = readFile.Split('\n');
//            Worker[] arrayWorkerFile = new Worker[arrayReadFile.Length];


//            Console.ReadKey();

//        }
//        else
//        {
//            Console.WriteLine("Фаил не найден");
//            Console.ReadKey();
//        }
//        // здесь происходит чтение из файла
//        // и возврат массива считанных экземпляров

//        return new Worker[0];
//    }

//    public Worker GetWorkerById(int id)
//    {
//        // происходит чтение из файла, возвращается Worker
//        // с запрашиваемым ID

//        return new Worker { Id = id };
//    }

//    public void DeleteWorker(int id)
//    {
//        // считывается файл, находится нужный Worker
//        // происходит запись в файл всех Worker,
//        // кроме удаляемого
//    }

//    public void AddWorker(Worker worker)
//    {
//        // присваиваем worker уникальный ID,
//        // дописываем нового worker в файл
//    }

//    public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
//    {
//        // здесь происходит чтение из файла
//        // фильтрация нужных записей
//        // и возврат массива считанных экземпляров

//        return new Worker[0];
//    }

//    private Worker ParsingWorker(string text) // Парсинг целой строки и создание нового объекта worker
//    {
//        string[] parsingTextInWorker = text.Split('#');

//        Worker worker = new Worker();

//        worker.Id = int.Parse(parsingTextInWorker[0]);
//        worker.fullName = $"{parsingTextInWorker[1]} {parsingTextInWorker[2]} {parsingTextInWorker[3]}";




//        return new Worker;
//    }
//}

