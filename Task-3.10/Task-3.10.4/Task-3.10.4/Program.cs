//Задание 4
//Пользователь вводит длину последовательности. 
//Затем пользователь последовательно вводит целые числа (как положительные, так и отрицательные). Числа разделяются клавишей Enter.
//Каждое введённое число сравнивается со значением переменной, отвечающей за минимальный элемент. 
//Если введённое число оказывается меньше, то нужно обновить значение переменной.

Console.WriteLine("Введите длинну последовательности");
string readLine = Console.ReadLine();
int minValue = int.MaxValue;

if (readLine == null || !int.TryParse(readLine, out int number)) 
{
    Console.WriteLine("Введено неверное значение");
}
else
{
    Console.WriteLine("Введите " + readLine + " чисел для сравнения");
    for (int i = 0; i < int.Parse(readLine); i++)
    {
        int readNum = int.Parse(Console.ReadLine());
        if(readNum < minValue)
        {
            minValue = readNum;
        }
    }
    Console.WriteLine("Минимальное из введенных: " + minValue);
    Console.ReadKey();
}
