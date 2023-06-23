//Задание 5
//Пользователь вводит максимальное целое число диапазона.
//На основе диапазона целых чисел (от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона. 
//Пользователю предлагается ввести загаданное программой случайное число. Пользователь вводит свои предположения в консоли приложения. 
//Если число меньше загаданного, программа сообщает об этом пользователю. 
//Если больше, то тоже сообщает, что число больше загаданного.
//Программа завершается, когда пользователь угадывает число. 
//Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.

Console.WriteLine("Введите целое число диапозона");
string ? readLine = Console.ReadLine();
Random random = new Random();
int randomNum = random.Next(int.Parse(readLine) + 1);

while (true)
{
    Console.WriteLine("Угадайте число");
    string newReadLineS = Console.ReadLine();
    if (newReadLineS == null)
    {
        break;
    }
 
    int? newReadLine = int.Parse(newReadLineS);
    
    if (newReadLine == randomNum)
    {
        Console.WriteLine("Верно!");
        Console.ReadKey();
        break;
    }
    else if (newReadLine > randomNum) 
    {
        Console.WriteLine("Загаданное число меньше введенного, попробуйте еще раз");
    }
    else if(newReadLine < randomNum)
    {
        Console.WriteLine("Загаданное число больше введенного, попробуйте еще раз");
    }
}





