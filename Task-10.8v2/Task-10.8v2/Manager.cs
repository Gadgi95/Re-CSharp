﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    internal class Manager : Consultant
    {
        Clients clients = new Clients();

        public Manager() { }

        //Переопределен метод, т.к. в классе Consultant паспортные данные были скрыты
        public override string GetClientInfo(Client client)
        {
            return $"Фамилия {client.LastName}"
                          + $"#Имя {client.FirstName}"
                          + $"#Отчество {client.Patronymic}"
                          + $"#Телефон {client.Phone} "
                          + $"#Серия и номер паспорта {client.SeriesAndNumberPasport}";
        }

        //Переопределен метод, для записи изменений от лица менеджера 
        public override string ChangeInfoClient(string whatChanged, string typeOfChanged)
        {
            DateTime dateTime = DateTime.Now;
            string whatChangedInfo = whatChanged;
            string typeOfChangedInfo = typeOfChanged;
            string whoChangedIt = "manager";

            return dateTime.ToString() + " " + whatChanged + " " + typeOfChanged + " " + whoChangedIt;
        }

        // Методы добавления информации для клиентов
        public bool AddClientLastName(long phoneNumber, string newLastName) 
        {  
            if(string.IsNullOrEmpty(newLastName))
            {
                return false;

            }
            else
            {
                Client client = clients.SearchClientForPhoneNumber(phoneNumber);

                SaveChangedInfo(ChangeInfoClient(client.LastName, newLastName));

                client.LastName = newLastName;

                return true;
            }
        }

        public bool AddClientFirstName(Client client, string newFirstName)
        {
            if (string.IsNullOrEmpty(newFirstName))
            {
                return false;

            }
            else
            {
                SaveChangedInfo(ChangeInfoClient(client.FirstName, newFirstName));

                client.FirstName = newFirstName;
                return true;
            }
        }

        public bool AddClientPatronymic(Client client, string newPatronymic)
        {
            if(string.IsNullOrEmpty (newPatronymic))
            {
                return false;
            }
            else
            {
                SaveChangedInfo(ChangeInfoClient(client.Patronymic, newPatronymic));

                client.Patronymic = newPatronymic;
                return true;
            }
        }

        public bool AddClientPhone(Client client, string newPhone)
        {
            if(long.TryParse(newPhone, out long result))
            {
                return false;
            }
            else
            {
                SaveChangedInfo(ChangeInfoClient(client.Phone.ToString(), newPhone.ToString()));

                client.Phone = result;
                return true;
            }
        }

        public bool AddClientSeriesAndNumberPasport(Client client, string newSeries)
        {
            if(string.IsNullOrEmpty(newSeries))
            {
                return false;
            }
            else
            {
                SaveChangedInfo(ChangeInfoClient(client.SeriesAndNumberPasport, newSeries));
                client.SeriesAndNumberPasport = newSeries;
                return true;
            }
        }

    }
}
