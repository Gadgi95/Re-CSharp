using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    internal class Manager : User
    {
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

                SaveChangedInfo(ChangeInfoClient(client.lastName, newLastName));

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
                SaveChangedInfo(ChangeInfoClient(client.firstName, newFirstName));

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
                SaveChangedInfo(ChangeInfoClient(client.patronymic, newPatronymic));

                client.patronymic = newPatronymic;
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
                SaveChangedInfo(ChangeInfoClient(client.phone.ToString(), newPhone.ToString()));

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
                SaveChangedInfo(ChangeInfoClient(client.seriesAndNumberPasport, newSeries));
                client.seriesAndNumberPasport = newSeries;
                return true;
            }
        }

        public override string ChangeInfoClient(string whatChanged, string typeOfChanged)
        {
            DateTime dateTime = DateTime.Now;
            string whatChangedInfo = whatChanged;
            string typeOfChangedInfo = typeOfChanged;
            string whoChangedIt = "manager";

            return whatChangedInfo;
        }
    }
}
