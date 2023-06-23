//Задание 1
//Пользователь вводит предложения с пробелами
//Создать метод static string[] SplitText(string text) который будет разделять текст на массив отдельных слов, используя пробел как обозначение разделения

Console.WriteLine("Задание 1");
Console.WriteLine("Введите предложение, которое необходимо разделить на слова");
string text = Console.ReadLine();

static string[] SplitText(string text)
{
    if(String.IsNullOrEmpty(text))
    {
        return new string[0];
    }
    else
    {
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        return words;
    }
    
}

foreach (string word in SplitText(text))
{
    Console.Write(word + " ");
}

Console.ReadKey();

//Задание 2
//Пользователь вводит в программе длинное предложение. Каждое слово отделено пробелом. После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:
//первый разделяет слова в предложении;
//второй меняет эти слова местами (в обратной последовательности). 
//Учтите, что один метод вызывается внутри другого метода, 
//то есть в методе main вызывается метод c сигнатурой ReversWords (string inputPhrase). 
//Внутри этого метода вызывается метод по разделению входной фразы на слова. 
//Метод должен выглядеть так: static string Reverse(string text), где text — это предложение, в котором необходимо поменять местами слова.

Console.WriteLine("Задание 2");

static string Reverse(string text)
{
    string reverseText = "";
    string[] newString = SplitText(text);

    for (int i = newString.Length - 1; i >= 0 ; i--) 
    {
        reverseText += newString[i] + " ";
    }
    return reverseText;
}

Console.WriteLine(Reverse(text));

Console.ReadKey();
