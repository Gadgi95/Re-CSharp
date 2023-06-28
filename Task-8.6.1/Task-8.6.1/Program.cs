//Создайте лист целых чисел. 
//Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
//Выведите коллекцию чисел на экран. 
//Удалите из листа числа, которые больше 25, но меньше 50. 
//Снова выведите числа на экран. 

List<int> numberList = new List<int>();

bool FillingInNumbers()
{
    Random r = new Random();

    for (int i = 0;i < 100; i++)
    {
        numberList.Add(r.Next(0, 101));
    }

    return true;
}

void PrintNumberList( List<int> list)
{
    foreach (int number in list)
    {
        Console.WriteLine(number);
    }
}

List<int> SortNumberList( List<int> list )
{
    List<int> result = new List<int>();

    foreach (int number in list)
    {

        if(number < 25 || number > 50)
        {
        result.Add(number);
        }
    }

    return result;
}

FillingInNumbers();

Console.WriteLine("New list");
PrintNumberList(numberList);

Console.WriteLine("Sort new list");
PrintNumberList(SortNumberList(numberList));



