using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    public class User : IUser
    {
        public User() { }

        
        public void ReadInfoClients(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("Клиент не найден");
            }
            else
            {
                string clientInfo = ClientInfo(client);

            }


        }

        public void SetPhoneNumbet(Client client)
        {
            string readline = Console.ReadLine();

            if (string.IsNullOrEmpty(readline) && long.TryParse(readline, out long newPhone))
            {
                client.phone = newPhone;
                Console.WriteLine("Номер телефона успешно изменен");
            }
            else
            {
                Console.WriteLine("Введено пустое значение или данные, не соответствующие номеру телефона");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Строку информация о клиенте с засекреченными паспортными данными</returns>
        public virtual string ClientInfo(Client client)
        {
            return $"Фамилия {client.lastName}"
                          + $"\nИмя {client.firstName}"
                          + $"\nОтчество {client.patronymic}"
                          + $"\nТелефон {client.phone} "
                          + $"\nСерия и номер паспорта {GetSeriesAndNumberPasportFromeUser(client)}"; ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Выражение преобразует серию и номер паспорта в *</returns>
        public string GetSeriesAndNumberPasportFromeUser(Client client)
        {
            return System.Text.RegularExpressions.Regex.Replace(client.seriesAndNumberPasport, @"\d", "*");
        }


    }
}
