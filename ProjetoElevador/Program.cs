using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Inicializar(elevador); // Exibe msg de boas vindas e recebe os dados do elevador
            ExibeMenu(elevador);
        }

        static void Inicializar(Elevador elevador)
        {
            int confirma = 0; // Trata o laço de repetição, se diferente de 0, ele encerra o laço

            Console.WriteLine("Bem-vindo ao Meu Elevador");
            Console.WriteLine("\nPara começar, preciso que informe a CAPACIDADE do elevador e o TOTAL DE ANDARES.");

            do
            {
                Console.WriteLine("Qual a capacidade de pessoas do elevador?");
                int capacidade = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Quantos andares o prédio possui?");
                int totalAndar = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"\nVocê informou que a capacidade do elevador é" +
                    $" de {capacidade} pessoa{(capacidade > 1 ? "s" : "")} e o prédio possui {totalAndar} andar{(totalAndar > 1 ? "es" : "")}.");
                Console.WriteLine("\nEstá correto?");
                Console.WriteLine("1 - SIM \n0 - NÃO");
                confirma = Convert.ToInt16(Console.ReadLine());

                if (confirma == 1)
                {
                    elevador.Inicializar(capacidade, totalAndar);

                    Console.Clear();
                }
            } while (confirma == 0);
        }

        static void ExibeMenu(Elevador elevador)
        {
            int confirma = 0;
            int opcao;
            do
            {
                Console.WriteLine("\n\nO que você deseja fazer?");
                Console.WriteLine("\n 1 - Entrar \n 2 - Sair \n 3 - Subir \n 4 - Descer \n 5 - Mostrar status do elevador\n 6 - Sair do programa");
                opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            elevador.Entrar();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            elevador.Sair();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            elevador.Subir();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            elevador.Descer();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine($"O elevador está com {elevador.QuantidadePessoa} pessoas " +
                                $"e está no {(elevador.AndarAtual == 0 ? "térreo" : $"{elevador.AndarAtual}° andar")}");
                            break;
                        }
                    case 6:
                        {
                            confirma = 1;
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opção inválida!!!");
                            break;
                        }
                }
            } while (confirma == 0);
        }
    }
}
