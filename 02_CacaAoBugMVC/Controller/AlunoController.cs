using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Controller
{
    internal class AlunoController
    {
        private readonly ValidacaoService _validacaoService;
        private readonly AlunoService _alunoService;
        private readonly List<Aluno> alunos;

        public AlunoController()
        {
            _validacaoService = new ValidacaoService();
            _alunoService = new AlunoService();
            alunos = new List<Aluno>();
        }
        public bool AdicionarAluno(Aluno aluno, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (!_validacaoService.ValidaNome(aluno.Nome, out string erroNome))
            {
                mensagemErro = $"Nome Inválido {erroNome}";
                return false;
            }

            aluno.Media = _alunoService.CalcularMedia(aluno.Nota1, aluno.Nota2, aluno.Nota3);

            aluno.Situacao = _alunoService.ObterSituacao(aluno.Media);

            alunos.Add(aluno);


            return true;
        }

        public IReadOnlyList<Aluno> ObterAlunos() => alunos.AsReadOnly();

        public double ObterTaxaAprovacao()
        {
            int totalAlunos = alunos.Count;
            int totalAprovados = alunos.FindAll(a => a.Situacao == "Aprovado").Count;
            return _alunoService.CalcularTaxaAprovacao(totalAlunos, totalAprovados);
        }

        public ValidacaoService GetValidacaoService() => _validacaoService;

        

    }
}