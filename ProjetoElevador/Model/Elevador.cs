using System;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        public int AndarAtual { get; set; } = 0; // o 0 representa o térreo
        public int TotalAndar { get; set; }
        public int Capacidade { get; set; }
        public int QuantidadePessoa { get; set; } = 0;

        public void Inicializar(int capacidade, int totalAndar)
        {
            TotalAndar = totalAndar;
            Capacidade = capacidade;
        }
        
        public void Entrar()
        {
         if(QuantidadePessoa < Capacidade)
            {
                QuantidadePessoa++;
            } else
            {
                Console.WriteLine("A capacidade máxima de pessoa foi atingida!");
            }
        }

        public void Sair()
        {
            if(QuantidadePessoa > 0)
            {
                QuantidadePessoa--;
            } else
            {
                Console.WriteLine("Não há mais pessoas no elevador!");
            }
        }

        public void Subir()
        {
            if(AndarAtual < TotalAndar)
            {
                AndarAtual++;
            }else
            {
                Console.WriteLine("Opa!!! Parece que você já chegou no último andar!");
            }
        }

        public void Descer()
        {
            if(AndarAtual > 0)
            {
                AndarAtual--;
            }
            else
            {
                Console.WriteLine("Epa!!! Você já está no térreo!");
            }
        }
    }
}
