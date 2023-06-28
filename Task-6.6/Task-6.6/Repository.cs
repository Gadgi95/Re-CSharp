using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._6
{
    //Задание 7.8
    //Создайте класс Repository, который будет отвечать за работу с экземплярами Worker.
    //В репозитории должны быть реализованы следующие функции:
    //Просмотр всех записей.
    //Просмотр одной записи. Функция должна на вход принимать параметр ID записи, которую необходимо вывести на экран. 
    //Создание записи.
    //Удаление записи.
    //Загрузка записей в выбранном диапазоне дат.

    public class Repository
    {
        string path = @"Employee Handbook.txt";


        public Worker[] GetAllWorkers()
        {

            if (File.Exists(path)) // Добавить путь к фаилу
            {
                string readFile = File.ReadAllText(path); // Путь к фаилу

                string[] arrayReadFile = readFile.Split(Environment.NewLine); //Создание и заполнение массива строками из фаила

                Worker[] workers = new Worker[arrayReadFile.Length];

                for (int i = 0; i <= arrayReadFile.Length - 1; i++)
                {
                    workers[i] = ParsingTextInWorker(arrayReadFile[i]);
                }

                return workers;

            }
            else
            {
                Console.WriteLine("Фаил не найден");
                return new Worker[0];
            }

        }

        public Worker GetWorkerById(int id)
        {
            /// происходит чтение из файла, возвращается Worker
            /// с запрашиваемым ID
            Worker newWorker = new Worker();

            if (!File.Exists(path))
            {
                Console.WriteLine("Фаил не найден");
                return newWorker;
            }
            else
            {
                string readFile = File.ReadAllText(path);

                string[] arrayReadFile = readFile.Split('\n');

                for (int i = 0; i <= arrayReadFile.Length; i++)
                {
                    Worker worker = ParsingTextInWorker(arrayReadFile[i]);

                    if (worker.Id == id)
                    {
                        newWorker = worker;
                    }
                }
                return newWorker;
            }
        }

        public void DeleteWorker(int id)
        {
            /// считывается файл, находится нужный Worker
            /// происходит запись в файл всех Worker,
            /// кроме удаляемого

            if (!File.Exists(path)) // Добавить путь к фаилу
            {
                Console.WriteLine("Фаил не найден");
                Console.ReadKey();
            }
            else
            {
                Worker[] arrayWorker = GetAllWorkers();

                for (int i = 0; i <= arrayWorker.Length; i++)
                {
                    if (arrayWorker[i].Id != id)
                    {
                        AddWorker(arrayWorker[i]);
                    }

                }
            }
        }

        public void AddWorker(Worker worker)
        {
            /// присваиваем worker уникальный ID,
            /// дописываем нового worker в файл

            if (!File.Exists(path)) 
            {
                File.WriteAllText(path, "1" + ParsingWorkerInText(worker));
            }
            else
            {
                string readFile = File.ReadAllText(path); // Путь к фаилу

                string[] arrayReadFile = readFile.Split('\n'); //Создание и заполнение массива строками из фаила

                string[] reArrayFileEmployee = new string[arrayReadFile.Length + 1];

                for (int i = 0; i < arrayReadFile.Length; i++)
                {
                    reArrayFileEmployee[i] = arrayReadFile[i];
                }

                worker.Id = reArrayFileEmployee.Length - 1;

                reArrayFileEmployee[reArrayFileEmployee.Length - 1] = ParsingWorkerInText(worker);

                File.WriteAllLines(path, reArrayFileEmployee);
            }

            Console.WriteLine("Сотрудник записан в справочник");
            Console.ReadKey();
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            /// здесь происходит чтение из файла
            /// фильтрация нужных записей
            /// и возврат массива считанных экземпляров

            Worker[] workers = GetAllWorkers();

            Worker[] searchWorkersFromeDate = new Worker[workers.Length];

            for (int i = 0; i <= workers.Length; i++)
            {
                if (workers[i].dateTimeAddedTheEntry >= dateFrom && workers[i].dateTimeAddedTheEntry <= dateTo)
                {
                    searchWorkersFromeDate[i] = workers[i];
                }
            }
            return searchWorkersFromeDate;
        }



        public Worker ParsingTextInWorker(string text) /// Парсинг целой строки в объект worker
        {
            string[] parsingTextInWorker = text.Split('#');

            Worker worker = new Worker();

            if (!int.TryParse(parsingTextInWorker[0], out int id))
            {
                worker.Id = 0;

                worker.dateTimeAddedTheEntry = DateTime.Parse($"{parsingTextInWorker[0]}");

                worker.fullName = parsingTextInWorker[1];

                worker.age = int.Parse(parsingTextInWorker[2]);

                worker.height = int.Parse(parsingTextInWorker[3]);

                worker.birthDay = DateTime.Parse($"{parsingTextInWorker[4]}");

                worker.placeOfBirth = parsingTextInWorker[5];
            }
            else
            {
                worker.Id = id;

                worker.dateTimeAddedTheEntry = DateTime.Parse($"{parsingTextInWorker[1]}");

                worker.fullName = parsingTextInWorker[2];

                worker.age = int.Parse(parsingTextInWorker[3]);

                worker.height = int.Parse(parsingTextInWorker[4]);

                worker.birthDay = DateTime.Parse($"{parsingTextInWorker[5]}");

                worker.placeOfBirth = parsingTextInWorker[6];
            }            

            return worker;
        }

        public string ParsingWorkerInText(Worker worker) /// Парсинг объекта worker в строку без ID
        {
            return $"{worker.Id}#{worker.dateTimeAddedTheEntry}#{worker.fullName}#{worker.age}#{worker.height}#{worker.birthDay}#{worker.placeOfBirth}";
        }

        public void PrintWorker(Worker worker) ///Вывод объекта Worker в консоль строкой
        {
           Console.Write($"{worker.Id} {worker.dateTimeAddedTheEntry} {worker.fullName} {worker.age} {worker.height} {worker.birthDay} {worker.placeOfBirth}" + "\n");
        }
    }
}
