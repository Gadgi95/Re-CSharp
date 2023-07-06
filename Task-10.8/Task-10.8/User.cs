using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8
{
    internal class User : IUser
    {
        public User() { }

        void IUser.ReadInfoClients(Clients client)
        {
            if(client == null) 
            {
                throw new ArgumentNullException("Клиент не найден");
            }
            else
            {
                string clientInfo = client.ToString();

                if (client.seriesAndNumberPasport == null) 
                {
                    Console.WriteLine(clientInfo);
                }
                else
                {
                    clientInfo += Clients.GetSeriesAndNumberPasportFromeUser(client);

                    Console.WriteLine(clientInfo);
                }


            }

            
        }

        public void SetPhoneNumbet(Clients clients)
        {
            string readline = Console.ReadLine();
            long.TryParse(readline, out long newPhone);
            clients.phone = newPhone;
        }
    }
}
