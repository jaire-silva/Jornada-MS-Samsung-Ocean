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

            painel.Interacao(elevador); 
            painel.ExibeMenu(elevador);
        }

    }
}
