using Task_10._8v2;


Console.WriteLine("Добро пожаловать в справочник клиентов компании");

for (int i = 0; i < Clients.listOfClients.Count; i++)
{
    Clients client = Clients.listOfClients[i];

    Console.WriteLine(client);
}




