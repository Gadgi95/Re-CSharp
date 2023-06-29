// Пользователь вводит число. Число сохраняется в HashSet коллекцию.
// Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение, что число уже вводилось ранее.
// Если числа нет, то появляется сообщение о том, что число успешно сохранено. 

HashSet<int> ints = new HashSet<int>();

Console.WriteLine("Вводите числа, каждое с новой строки для сохранения");

void AddNewNumsInInts()
{
    int.TryParse(Console.ReadLine(), out int num);

    if(ints.Contains(num))
    {
        Console.WriteLine("Такое число уже присутствует в коллекции");
        return;
    }
    else 
    {
        ints.Add(num); 
        Console.WriteLine("Число записано"); 
    }
}

while (true)
{
    AddNewNumsInInts();
}

