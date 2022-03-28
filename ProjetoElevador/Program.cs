using ProjetoElevador.Model;
using ProjetoElevador.Controller;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elevador = new Elevador();
            var painel = new Painel();

            // Exibe msg de boas vindas e recebe os dados do elevador
            painel.Inicializar(elevador); 
            painel.ExibeMenu(elevador);
        }

    }
}
