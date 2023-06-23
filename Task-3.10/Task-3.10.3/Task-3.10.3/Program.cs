//Задание 3
//Для начала пользователь вводит целое число.
//Затем в цикле нужно перебрать все числа, начиная с 1 и до N − 1.
//Входное число N при каждой итерации цикла нужно делить на число, которое получается в цикле с остатком.
//Если остаток от деления равен 0, значит, программа нашла делитель этого числа, и потому это число уже не может являться простым числом.
//Если остаток от деления равен 0, то переменной bool, объявленной за рамками цикла, следует присвоить значение true.
//Если после выхода из цикла значение переменной осталось false, 
//значит, число простое. Если значение переменной стало true, значит, был найден делитель, поэтому число не может считаться простым.


Console.WriteLine("Здраствуйте! Введите целое число");
string readLine = Console.ReadLine();
bool primeNumTest = false;

if(readLine == null || !int.TryParse(readLine, out int number))
{
    Console.WriteLine("Введено неверное значение");
    Console.ReadKey();
    return;
}
else
{
    int readLineParseNum = int.Parse(readLine);

    for(int i = 2; i < int.Parse(readLine) - 1; i++)
    {
        if(readLineParseNum % i == 0)
        {
            primeNumTest = true;
            break;
        }
        else if(readLineParseNum % i != 0)
        {
            readLineParseNum = readLineParseNum % i;
        }

    }
}

if (primeNumTest)
{
    Console.WriteLine("Число не является простым");
}
else
    Console.WriteLine("Число является простым");

Console.ReadKey();
