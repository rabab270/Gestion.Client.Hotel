using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3RA
{
    internal class Program
    {
        class Client
            {
                public string Nom { get; set; }
                public string Prenom { get; set; }
                public string Courriel { get; set; }
                public string CarteDeCredit { get; set; }
                public int NumeroDeChambre { get; set; }

                public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroDeChambre)
                {
                    Nom = nom;
                    Prenom = prenom;
                    Courriel = courriel;
                    CarteDeCredit = carteDeCredit;
                    NumeroDeChambre = numeroDeChambre;
                }
            }

            class Hotel
            {
                public List<Client> ListeClients { get; set; }

                public Hotel()
                {
                    ListeClients = new List<Client>();
                }

                public void AjouterClient(Client client)
                {
                    ListeClients.Add(client);
                }
            }

            class Programme
            {
                static void Main(string[] args)
                {
                    Hotel hotel = new Hotel();

                    Client client1 = new Client("Achchar", "Rabab", "Rabab.achchar@gmail.com", "444-444-444-444", 183);
                    hotel.AjouterClient(client1);

                    Client client2 = new Client("ACHCHAR", "Omar", "Omar.achchar@hotmail.com", "555-555-555-555", 197);
                    hotel.AjouterClient(client2);

                    Client client3 = new Client("ACHCHAR", "Leila", "Leila.achchar@email.com", "666-666-666-666", 205);
                    hotel.AjouterClient(client3);

                foreach (Client client in hotel.ListeClients)
                    {
                        Console.WriteLine("{0} {1} ({2}), chambre {3}, carte de crédit : {4}", client.Prenom, client.Nom, client.Courriel, client.NumeroDeChambre, client.CarteDeCredit);
                    }
                }
            }

        }
    }
