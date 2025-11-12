namespace _02_CacaAoBugMVC.Model
{
    class Aluno
    {
        /*private string nome = string.Empty;
        
        //metodos acessadores
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }*/
        public string nome { get; set; } = string.Empty;
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public string situacao { get; set; } = string.Empty;
    }
}
