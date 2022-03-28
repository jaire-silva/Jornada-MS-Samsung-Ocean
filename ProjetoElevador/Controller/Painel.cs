using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador.Controller
{
    public class Painel
    {
        public void Interacao(Elevador elevador)
        {
            // Trata o laço de repetição, se diferente de 0, ele encerra o laço.
            var confirmacao = -1;

            Console.WriteLine("Bem-vindo \nPara começar, preciso que me informe a CAPACIDADE do elevador e o TOTAL DE ANDARES do prédio.");

            do
            {
                var capacidade = -1;
                var totalAndar = -1;

                // Entrada da quantidade de pessoas maximas no elevador.
                // Verificação se o valor da entrada é valido.
                do
                {
                    Console.WriteLine("Qual a capacidade de pessoas do elevador?");
                    try
                    {
                        capacidade = Convert.ToInt32(Console.ReadLine());
                        if (capacidade < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        capacidade = -1;
                        Console.Clear();
                        Console.WriteLine("Houve um erro, preciso que digite novamente a capacidade de pessoas do elevador.\n");
                        Console.WriteLine("Entre com um número inteiro maior que 0 por favor.");
                    }
                } while (capacidade == -1);

                // Entrada da quantidade de andares.
                // Verificação se o valor da entrada é valido.
                do
                {
                    Console.WriteLine("Quantos andares o prédio possui?");
                    try
                    {
                        totalAndar = Convert.ToInt32(Console.ReadLine());

                        if (totalAndar < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        totalAndar = -1;
                        Console.Clear();
                        Console.WriteLine("Houve um erro, preciso que digite novamente o total de andares do prédio.\n");
                        Console.WriteLine("Entre com um número inteiro maior que 0 por favor.");
                    }
                } while (totalAndar == -1);


                Console.WriteLine($"\nVocê informou que:" +
                    $"\na capacidade do elevador é de {capacidade} pessoa{(totalAndar > 1 ? "s" : "")} " +
                    $"\no prédio possui {totalAndar} andar{(totalAndar > 1 ? "es" : "")}.");

                Console.WriteLine("\nEstá correto?");


                // Perguntar para o usuário se os dados informados estão corretos.
                do
                {
                    Console.WriteLine("1 - SIM \n0 - NÃO");
                    try
                    {
                        confirmacao = Convert.ToInt32(Console.ReadLine());

                        if ((confirmacao != 0) && (confirmacao != 1))
                        {
                            throw new Exception();
                        }

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Não existe essa opção.\n");
                        Console.WriteLine($"Você informou que:" +
                            $"\na capacidade do elevador é de {capacidade} pessoa{(totalAndar > 1 ? "s" : "")} " +
                            $"\no prédio possui {totalAndar} andar{(totalAndar > 1 ? "es" : "")}.");
                        confirmacao = -1;
                    }
                } while (confirmacao == -1);


                if (confirmacao == 1)
                {
                    elevador.Inicializar(capacidade, totalAndar);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bem-vindo novamenta. \nVamos tentar de novo, preciso que me informe a CAPACIDADE do elevador e o TOTAL DE ANDARES do prédio.");
                }

            } while (confirmacao == 0);
        }

        public void ExibeMenu(Elevador elevador)
        {
            var opcao = -1;


            do
            {
                Console.WriteLine("Elevador atualmente com {0} de {1} pessoas", elevador.qtdPessoa, elevador.capacidade);
                Console.WriteLine("Elevador atualmente no {0} de {1} andares", elevador.andarAtual, elevador.totalAndar);
                Console.WriteLine("\n\nO que você deseja fazer?");
                Console.WriteLine("\n 1 - Entrar \n 2 - Sair \n 3 - Subir \n 4 - Descer \n 5 - Sair do programa");

                
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    opcao = -1;
                }


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
                    
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opção inválida!!!\n\n");
                            break;
                        }
                }
            } while (opcao != 5);
        }


    }
}
