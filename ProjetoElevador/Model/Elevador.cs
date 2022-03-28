using System;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        // O 0 representa o térreo.
        public int andarAtual { get; set; } = 0;
        public int totalAndar { get; set; }
        public int qtdPessoa { get; set; } = 0;
        public int capacidade { get; set; }

        public void Inicializar(int capacidade, int totalAndar)
        {
            this.totalAndar = totalAndar;
            this.capacidade = capacidade;
        }

        public void Entrar()
        {
            if (qtdPessoa < capacidade)
            {
                qtdPessoa++;
            }
            else
            {
                Console.WriteLine("A capacidade máxima de pessoa foi atingida!");
            }
        }

        public void Sair()
        {
            if (qtdPessoa > 0)
            {
                qtdPessoa--;
            }
            else
            {
                Console.WriteLine("Não há mais pessoas no elevador!");
            }
        }

        public void Subir()
        {
            if (andarAtual < totalAndar)
            {
                andarAtual++;
            }
            else
            {
                Console.WriteLine("Opa!!! Parece que você já chegou no último andar!");
            }
        }

        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
            }
            else
            {
                Console.WriteLine("Epa!!! Você já está no térreo!");
            }
        }
    }
}
