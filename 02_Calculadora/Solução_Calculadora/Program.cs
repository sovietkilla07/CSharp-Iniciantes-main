using System;

namespace NovaCalculadora
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }


        public static void Menu()
        {

            Console.Clear();

            Console.WriteLine(@$"
            
            Menu da Calculadora

            Escolha uma das opções abaixo:


            1 - Somar
            2 - Subtrair
            3 - Multiplicar
            4 - Dividir
            5 - Encontrar resto da divisão
            6 - Realizar potencialização
            0 - Sair
            
            ");

            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Somar();
                break;

                case "2":
                    Subtrair();
                break;

                case "3":

                break;

                case "4":

                break;

                case "5":

                break;

                case "6":

                break;

                case "0":

                break;

                default:

                Console.Clear();
                Console.WriteLine("Opção inválida. Por favor, digite outra opção (entre 0 e 6).");
                Thread.Sleep(5000);
                Menu();

                break;
            }

        }

        public static void Somar()
        {

            double valor1, valor2;

            Console.WriteLine("Você escolheu a opção Somar!");

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");


        }

        public static void Subtrair()
        {
            double valor1, valor2;

            Console.WriteLine("Você escolheu a opção Subtrair!");

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
        }
    }
}

//Para sair do console, segure as teclas "Ctrl" e "C" ao mesmo tempo.