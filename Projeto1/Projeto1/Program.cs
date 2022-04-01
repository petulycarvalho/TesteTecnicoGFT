using System;
using System.Collections.Generic;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hardware> hardwares = new List<Hardware>();

            Console.WriteLine("1 - Cadastrar Equipamento");
            Console.WriteLine("2 - Listar Equipamentos Cadastrados");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    hardwares.Add(CadastrarEquipamento());
                    break;
                case 2:
                    ListarEquipamentos(hardwares);
                    break;
                default:
                    break;
            }
        }

        public static Hardware CadastrarEquipamento()
        {
            Console.WriteLine("Qual hardware voce deseja cadastrar");
            Console.WriteLine("1 - CPU");
            Console.WriteLine("2 - Memoria");
            Console.WriteLine("3 - Disco Rigido");

            int opcao = int.Parse(Console.ReadLine());

            int id = 0;
            string descricao = "";
            double valor = 0;
            string fabricante = "";

            Console.WriteLine("Digite o ID do hardware");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descricao do hardware");
            descricao = Console.ReadLine();

            Console.WriteLine("Digite o valor do hardware");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o fabricante do hardware");
            fabricante = Console.ReadLine();

            if (opcao == 1)
            {
                double clock = 0;
                string modelo = "";

                Console.WriteLine("Digite o clock do hardware");
                clock = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o modelo do hardware");
                modelo = Console.ReadLine();

                return new CPU(id, descricao, valor, fabricante, clock, modelo);
            }
            else if (opcao == 2)
            {
                int frequencia = 0;
                int capacidade = 0;
                string tipo = "";

                Console.WriteLine("Digite a frequencia do hardware");
                frequencia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a capacidade do hardware");
                capacidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o tipo do hardware");
                tipo = Console.ReadLine();

                return new Memoria(id, descricao, valor, fabricante, frequencia, capacidade, tipo);
            }
            else
            {
                int velocidade = 0;
                int capacidade = 0;
                string tipo = "";

                Console.WriteLine("Digite a velocidade do hardware");
                velocidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a capacidade do hardware");
                capacidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o tipo do hardware");
                tipo = Console.ReadLine();

                return new DiscoRigido(id, descricao, valor, fabricante, capacidade, velocidade, tipo);
            }
        }

        public static void ListarEquipamentos(List<Hardware> hardwares)
        {
            foreach (Hardware hardware in hardwares)
            {
                Console.WriteLine(hardware.getDetalhesHardware());
            }
        }
    }
}
