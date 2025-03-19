

namespace Tp3_Csharp
{
    class Program
    {
        static void Main()
        {
            
            // Ex 1
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Leonardo";
            pessoa1.Idade = 31;

            pessoa1.ExibirInformacoes();

            // Ex 2 - 6 

            Ingresso ingresso1 = new Ingresso("Rock Festival", 150.0, 100);


            ingresso1.ExibirInformacoes();


            ingresso1.AlterarPreco(180.0);
            ingresso1.AlterarQuantidade(90);


            Console.WriteLine("\nApós atualização:");
            ingresso1.ExibirInformacoes();


            ingresso1.SetNomeDoShow("Jazz Festival");
            Console.WriteLine("\nNome atualizado: " + ingresso1.GetNomeDoShow());
            
            // Ex 7 - 9

            Matricula matricula = new Matricula("Leonardo Guilhon", "Análise e Desenvolvimento de Sistemas", 2602, "19/03/2025");
            matricula.ExibirInformacoes();

            matricula.Trancar();
            Console.WriteLine("Após trancar a matrícula:");
            matricula.ExibirInformacoes();

            matricula.Reativar();
            Console.WriteLine("Após reativar a matrícula:");
            matricula.ExibirInformacoes();

            

            // Ex 10 - 12

            Circulo circulo = new Circulo(3.0);
            Console.WriteLine("Área do Círculo: " + circulo.CalcularArea());

            Esfera esfera = new Esfera(5.0);
            Console.WriteLine("Volume da Esfera: " + esfera.CalcularVolume());
        }
    }
}
