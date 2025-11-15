using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
     class AlunoService
    {
        public double CalcularMedia(double n1, double n2, double n3)
        {
            return Math.Round((n1 + n2 + n3) / 3.0, 2);
        }
        public string ObterSituacao(double media)
        {
            if (media >= 7)
                return "Aprovado";
            else if (media >= 5)
                return "Recuperação";
            else
                return "Reprovado";
        }
        public double CalcularTaxaAprovacao(int totalAlunos, int alunosAprovados)
        {
            // (double) serve para converter a variavel em double, chamado de CAST
            if (totalAlunos == 0) return 0.0;
            return (alunosAprovados / (double)totalAlunos) * 100.0;
        }
    }
}
