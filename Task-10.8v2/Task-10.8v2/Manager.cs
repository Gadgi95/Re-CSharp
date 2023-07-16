using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    internal class Manager : User
    {
        User user = new User();

        Clients clients = new Clients();

        public Manager() { }

        public override string ClientInfo(Client client)
        {
            return client.ToString();
        }

        public bool AddClientLastName(long phoneNumber, string newLastName) 
        {  
            if(string.IsNullOrEmpty(newLastName))
            {
                return false;

            }
            else
            {
                Client client = clients.SearchClientForPhoneNumber(phoneNumber);

                client.lastName = newLastName;

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
                client.firstName = newFirstName;
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
                client.patronymic = newPatronymic;
                return true;
            }
        }

        public bool AddClientPhone(Client client, string newPhone)
        {
            if(int.TryParse(newPhone, out int result))
            {
                return false;
            }
            else
            {
                client.phone = result;
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
                client.seriesAndNumberPasport = newSeries;
                return true;
            }
        }
    }
}
