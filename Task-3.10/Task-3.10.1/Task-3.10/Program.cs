//Задание 1
// - На экране программа с помощью оператора Console.WriteLine предлагает пользователю ввести целое число.
// - С помощью оператора Console.ReadLine считывается введённое число.
// - С помощью метода int.Parse число преобразуется в целочисленную переменную.
// - С помощью оператора деления с остатком определяется, чётное число или нечётное.
// - В зависимости от предыдущего шага на экран выводится текст, является ли данное число чётным или нет.


Console.WriteLine("Введите целое цисло");
string reader = Console.ReadLine();
int readNum;

if(reader == null || reader == "0")
{
    Console.WriteLine("Вы не ввели значение!");
    return;
}

readNum = int.Parse(reader);
Console.WriteLine("Введено число: " + readNum);

if (readNum % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else if(readNum % 2 != 0)
{
    Console.WriteLine("Число нечетное");
}
Console.ReadKey();

