using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
        Client client = new Client();

        client.FirstName = "Su Nombre";
        client.LastName = "Su Apellido";
        client.Age = 30;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
        }

    }
    
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

}




