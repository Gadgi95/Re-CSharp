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
    }
    else
    {
        Console.WriteLine("Фаил не найден");
    }
}
else if(valueReadLine == 2 )
{
    AddNewEmployee();
}
else
{
    Console.WriteLine("Введены не верные данные!");
    return;
}

string UserInputNewEmployee()
 
{
    Console.WriteLine("Введите ФИО сотрудника в формате \"Иванов Иван Иванович\":");
    string fullName = Console.ReadLine();

    Console.WriteLine("Введите возраст сотрудника:");
    int.TryParse(Console.ReadLine(), out int age);

    Console.WriteLine("Введите рост сотрудника:");
    int.TryParse(Console.ReadLine(), out int height);

    Console.WriteLine("Введите дату рождения сотрудника в формате дд.мм.гггг:");
    DateTime.TryParse(Console.ReadLine(), out DateTime birthDay);

    Console.WriteLine("Введите место рождения сотрудника:");
    string placeOfBirth = Console.ReadLine();

    return $"#{DateTime.Now}#{fullName}#{age}#{height}#{birthDay}#{placeOfBirth}";
}

void AddNewEmployee()
{
    if (!File.Exists(path))
    {
        File.WriteAllText(path, "1" + UserInputNewEmployee());
        return;
    }

    string[] arrayFileEmployee = File.ReadAllLines(path);

    string newEmployee = (arrayFileEmployee.Length + 1) + UserInputNewEmployee();

    string[] reArrayFileEmployee = new string[arrayFileEmployee.Length + 1];

    for (int i = 0; i < arrayFileEmployee.Length; i++)
    {
            reArrayFileEmployee[i] = arrayFileEmployee[i];
    }

    reArrayFileEmployee[reArrayFileEmployee.Length - 1] = newEmployee;

    File.WriteAllLines(path, reArrayFileEmployee);
}

Console.ReadKey();

