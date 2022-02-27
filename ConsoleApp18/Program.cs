using System;

// Reserva de quartos utilizando array

namespace ConsoleApp18
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Quantos Quartos serão alugados: ");
            int quartos = int.Parse(Console.ReadLine());

            Cliente[] alugado = new Cliente[quartos];

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int quart = int.Parse(Console.ReadLine());
                alugado[i] = new Cliente(nome, email, quart);



            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            
            foreach (Cliente alug in alugado)
            {
                Console.WriteLine(alug);
            }

        }
    }
}
