///Задание 2
//Программа приветствует пользователя и спрашивает, сколько у него на руках карт.
//Пользователь вводит целое число.
//Преобразуем это число в счётчик для цикла.
//С помощью цикла for итеративно просим пользователя ввести номинал каждой карты. Для карт с числовым номиналом он вводит только цифру. 
//Для «картинок» следует принять обозначения латинскими буквами:
//Валет = J
//Дама = Q
//Король = K
//Туз = T
//Внутри цикла, используя оператор switch, «вес» каждой карты складываем в общую переменную суммы, которая объявлена до тела основного цикла.
//Для числовых карт их «вес» равен весу, указанному при вводе пользователем. Для «картинок» «вес» равен 10.
//По завершении ввода на экране появится значение суммы карт.


Console.WriteLine("Приветствую! Введите числом, сколько карт у Вас на руках?");
int summCards = 0;
string numberOfCards = Console.ReadLine();
int parsedNumberOfCards = int.Parse(numberOfCards);

if (!int.TryParse(numberOfCards, out int parsedNumber) || parsedNumberOfCards == 0)
{
    Console.WriteLine("Введено неверное значение или 0");
    Console.ReadKey();
    return;
}

for (int i = 0; i < parsedNumberOfCards; i++)
{
    Console.WriteLine("Напишите через ENTER номинал каждой карты");

    string readline = Console.ReadLine();

    if(readline is null)
    {
        Console.WriteLine("Введено неверное значение");
        Console.ReadKey();
        return;
    }
    else if (int.TryParse(readline, out int parsedNumber2) && int.Parse(readline) >= 2 && int.Parse(readline) <= 10) {
        summCards += int.Parse(readline);
    }
    else if(!int.TryParse(readline, out int parsedNumber3))
    {
        switch (readline)
        {
            case "J":
                summCards += 10;
                break;
            case "Q":
                summCards += 10;
                break;
            case "K":
                summCards += 10;
                break;
            case "T":
                summCards += 10;
                break;

        }
    }
}

Console.WriteLine("Сумма карт на руках: " +  summCards);
Console.ReadKey();
