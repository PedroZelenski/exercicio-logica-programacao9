using System;

namespace exercicio_logica_programacao9
{
    class Program
    {
        static void Main(string[] args)
        {
            VotacaoService votacaoService = new VotacaoService();
            votacaoService.VotosValidos();
            votacaoService.VotosBrancos();
            votacaoService.VotosNulos();
        }
    }
}
