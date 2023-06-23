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

DateTime dateTimeAddedTheEntry;
string fullName;
int age;
int height;
DateTime birthDay;
string placeOfBirth;

string path = @"C:\Users\user\Desktop\C#\skillbox\CSharp\Task-6.6\Employee Handbook.txt";

Console.WriteLine("Добро пожаловать в справочник\nВыберите действие:\n1 - вывести справочник на экран\n2 - заполнить данные и добавить новую запись");
string readLine = Console.ReadLine();
if(String.IsNullOrEmpty(readLine))
{
    Console.WriteLine("Введена пустая строка");
    Console.ReadKey();
    return;
}
int valueReadLine = int.Parse(readLine);

if(valueReadLine == 1 )
{
    if(File.Exists(path))
    {
        string readFile = File.ReadAllText(path);
        string[] arrayReadFile = readFile.Split(new char[] { '#' });
        foreach(string str in arrayReadFile)
        {
            Console.Write(str + " ");
        }
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("Фаил не найден");
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
    dateTimeAddedTheEntry = DateTime.Now;
    Console.WriteLine("Введите ФИО сотрудника:");
    fullName = Console.ReadLine();
    Console.WriteLine("Введите возраст сотрудника:");
    age = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост сотрудника:");
    height = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите дату рождения сотрудника в формате дд.мм.гггг:");
    birthDay = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Введите место рождения сотрудника:");
    placeOfBirth = Console.ReadLine();

    return ($"#{dateTimeAddedTheEntry}#{fullName}#{age}#{height}#{birthDay}#{placeOfBirth}");
}

void addNewEmployee()
{
    if (File.Exists(path))
    {
        string[] arrayFileEmployee = readFileLines();

        string newEmployee = (arrayFileEmployee.Length + 1) + userInputNewEmployee();

        string[] reArrayFileEmployee = new string[arrayFileEmployee.Length + 1];

        for (int i = 0; i < arrayFileEmployee.Length; i++)
        {
            reArrayFileEmployee[i] = arrayFileEmployee[i];
        }

        reArrayFileEmployee[reArrayFileEmployee.Length - 1] = newEmployee;

        File.WriteAllLines(path, reArrayFileEmployee);
    }
    else
    {
        File.WriteAllText(path, "1" + userInputNewEmployee());
    }
}

string[] readFileLines()
{
    string[] readFile = File.ReadAllLines(path);
    return readFile;
}






