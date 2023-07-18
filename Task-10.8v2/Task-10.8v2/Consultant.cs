﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{

    public class Consultant : IUser, Repository
    {
        public Consultant() { }

        //Реализация методов наследованных от интерфейса IUser

        public void ReadInfoClients(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("Клиент не найден");
            }
            else
            {
                string clientInfo = GetClientInfo(client);

            }


        }

        public void SetPhoneNumber(Client client)
        {
            string readline = Console.ReadLine();

            if (string.IsNullOrEmpty(readline) && long.TryParse(readline, out long newPhone))
            {
                SaveChangedInfo(ChangeInfoClient(client.Phone.ToString(), newPhone.ToString()));

                client.Phone = newPhone;

                Console.WriteLine("Номер телефона успешно изменен");
            }
            else
            {
                Console.WriteLine("Введено пустое значение или данные, не соответствующие номеру телефона");
            }

        }

        public virtual string ChangeInfoClient(string whatChanged, string typeOfChanged)
        {
            DateTime dateTime = DateTime.Now;

            string whoChangedIt = "user";

            return dateTime.ToString() + " " + whatChanged + " " + typeOfChanged + " " + whoChangedIt;
        }

        public void SaveChangedInfo(string changedInfo)
        {
            string path = @"List changed info of clients.txt";

            if (!File.Exists(path))
            {

                File.WriteAllText(path, changedInfo);
            }
            else
            {
                string readFile = File.ReadAllText(path); // Путь к фаилу

                string[] arrayReadFile = readFile.Split(Environment.NewLine); //Создание и заполнение массива строками из фаила

                string[] newFile = new string[arrayReadFile.Length + 1];

                foreach (string file in arrayReadFile)
                {
                    newFile[0] = file;
                }
                newFile[arrayReadFile.Length - 1] = changedInfo;

                File.WriteAllLines(path, newFile);

            }
        }


        //Методы для получения информации о клиенте, с скрытыми паспортными данными

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Строку информация о клиенте с засекреченными паспортными данными</returns>
        public virtual string GetClientInfo(Client client)
        {
            return $"Фамилия {client.LastName}"
                          + $"#Имя {client.FirstName}"
                          + $"#Отчество {client.Patronymic}"
                          + $"#Телефон {client.Phone} "
                          + $"#Серия и номер паспорта {GetSeriesAndNumberPasportFromeUser(client)}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Выражение преобразует серию и номер паспорта в *</returns>
        public string GetSeriesAndNumberPasportFromeUser(Client client)
        {
            return System.Text.RegularExpressions.Regex.Replace(client.SeriesAndNumberPasport, @"\d", "*");
        }



    }
}