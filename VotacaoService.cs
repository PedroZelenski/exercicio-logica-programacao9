using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao9
{
    class VotacaoService
    {
        public int TotalDeEleitores { get; set; }
        public double Validos { get; set; }
        public double Brancos { get; set; }
        public double Nulos { get; set; }
        public int Percentual = 100;

        public VotacaoService()
        {
            Console.Write("Digite o total de eleitores: ");
            TotalDeEleitores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o total de votos validos: ");
            Validos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o total de votos brancos: ");
            Brancos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o total de votos nulos: ");
            Nulos = Convert.ToInt32(Console.ReadLine());
        }

        public void VotosValidos()
        {
            if (TotalDeEleitores != Validos + Brancos + Nulos)
                Console.WriteLine("O numero de votos nao bate com o de eleitores!");
            else
            {
                Console.WriteLine($"O percentual de votos validos e de: {Validos / TotalDeEleitores * Percentual}%");
            }
        }

        public void VotosBrancos()
        {
            if (TotalDeEleitores != Validos + Brancos + Nulos)
                Console.WriteLine("O numero de votos nao bate com o de eleitores!");
            else
            {
                Console.WriteLine($"O percentual de votos brancos e de: {Brancos / TotalDeEleitores * Percentual}%");
            }
        }

        public void VotosNulos()
        {
            if (TotalDeEleitores != Validos + Brancos + Nulos)
                Console.WriteLine("O numero de votos nao bate com o de eleitores!");
            else
            {
                Console.WriteLine($"O percentual de votos nulos e de: {Nulos / TotalDeEleitores * Percentual}%");
            }
        }
    }
}
