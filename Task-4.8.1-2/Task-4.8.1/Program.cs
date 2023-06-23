//Задание 1
//Сначала пользователю предлагается ввести количество строк в будущей матрице.
//Затем — ввести количество столбцов в будущей матрице.
//Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
//Используя Random, заполнить матрицу случайными целыми числами.
//Вывести полученную матрицу на экран. 
//Вывести сумму всех элементов этой матрицы на экран отдельной строкой.


    
    
Console.WriteLine("Введите количество строк в матрице");
string arrayNumberLines = Console.ReadLine();
int parseArrayNumberLines = 0;
if(!String.IsNullOrEmpty(arrayNumberLines))
{
    int.TryParse(arrayNumberLines, out parseArrayNumberLines);
}

Console.WriteLine("Введите колличество столбцов");
string arrayNumberColumns = Console.ReadLine();
int parseArrayNumberColumns = 0;
if (!String.IsNullOrEmpty(arrayNumberColumns))
{
    int.TryParse(arrayNumberColumns, out parseArrayNumberColumns);
}

int[,] matrix = new int[parseArrayNumberLines, parseArrayNumberColumns];

Random random = new Random();

for (int lines = 0; lines < parseArrayNumberLines; lines++)
{
    for (int columns = 0; columns < parseArrayNumberColumns; columns++)
    {
        matrix[lines, columns] = random.Next(-9, 10);
        Console.Write($"{matrix[lines, columns]}");
    }
    Console.WriteLine();
}
Console.ReadKey();

//Задание 2
//Используя размеры матрицы из предыдущего задания, создайте ещё одну матрицу. Сложите две матрицы. 

Console.WriteLine("Задание 2");
int[,] secondMatrix = new int[parseArrayNumberLines, parseArrayNumberColumns];

for (int lines = 0; lines < parseArrayNumberLines; lines++)
{
    for (int columns = 0; columns < parseArrayNumberColumns; columns++)
    {
        secondMatrix[lines, columns] = random.Next(10);
        Console.Write($"{secondMatrix[lines, columns]}");
    }
    Console.WriteLine();
}
Console.ReadKey();

Console.WriteLine("Сложение матриц A+B: ");

int[,] newMatrix = new int[parseArrayNumberLines, parseArrayNumberColumns];
for (int lines = 0; lines < parseArrayNumberLines; lines++)
{
    for (int columns = 0; columns < parseArrayNumberColumns; columns++)
    {
        newMatrix[lines, columns] = matrix[lines, columns] + secondMatrix[lines, columns];
        Console.Write($"{newMatrix[lines, columns]}");
    }
    Console.WriteLine();
}
Console.ReadKey();



