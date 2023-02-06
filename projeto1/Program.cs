using projeto1.Entities.Enums;
using projeto1.Entities;
using System;
using System.Data;
using System.Globalization;



namespace projeto1
{
    class Program
    { 
            static void Main(string[] args)
            {
                Console.WriteLine("Inserir dados do cliente: ");
                Console.Write("Nome: ");
                string clientName = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Data de nascimento (DD/MM/YYYY): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Insira os dados do pedido: ");
                
                Console.Write("Qual Status: \r\n 1: PendingPayment \r\n 2: Processing \r\n 3: Shipped \r\n 4: Delivered \r\n  ");
                OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

                Client client = new Client(clientName, email, birthDate);
                Order order = new Order(DateTime.Now, status, client);

                Console.Write("Quantos itens para este pedido? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Entrar #{i} dados do item:");
                    Console.Write("Nome do produto: ");
                    string productName = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new Product(productName, price);

                    Console.Write("Quatidade: ");
                    int quantity = int.Parse(Console.ReadLine());
                    OrdeItem orderItem = new OrdeItem(quantity, price, product);

                    order.AddItem(orderItem);
                }

                Console.WriteLine();
                Console.WriteLine("RESUMO DO PEDIDO:");
                Console.WriteLine(order);
            }
        }
    }



   