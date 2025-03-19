using System;

class Matricula
{
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; private set; }
    public string DataInicial { get; set; }

    public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        DataInicial = dataInicial;
        Situacao = "Ativa"; // matrícula inicia ativa
    }

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Aluno: {NomeDoAluno}\nCurso: {Curso}\nNúmero de Matrícula: {NumeroMatricula}\nSituação: {Situacao}\nData Inicial: {DataInicial}\n");
    }
}

