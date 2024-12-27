using NUnit.Framework;
using Area1;

namespace Area.Tests;

[TestFixture]
public class Tests
{
  public static IEnumerable<TestCaseData> lerDadosDeTeste(string operacao)
    {
        string caminhoMassa = @"C:\iterasys\Area\Area.Tests\fixture\"; //caminho do arquivo CSV

        switch(operacao)
        {
            case "T":
                caminhoMassa += @"triangulo.csv";
                break;

        }

        using (var leitor = new StreamReader(caminhoMassa))
        {
            // pular a primeira linha - cabeçalho
            leitor.ReadLine();


            // Repetir as ações ate a condição se realizar.
            // nesse caso, seria ate o arquivo CSV terminar.
            // repita enquanto não for o final
            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine(); // lendo uma linha 
                var valores = linha.Split(","); // dividir em campos

                yield return new TestCaseData(int.Parse(valores[0]), int.Parse(valores[1]), int.Parse(valores[2]), int.Parse(valores[3]));

            }
          

        }

    }


   [Test]
   public void testAreaQuadrado()
   {
   int num1 = 4;
   int num2 = 4;
   int resultadoEsperado = 16;

   int resultadoAtual = AreaGeometrica.areaquadrado(num1, num2);

   Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
   }

    [Test]
    public void testAreaQuadradoErro()
    {
    int num1 = 4;
    int num2 = 4;
    int resultadoEsperado = 8;

    int resultadoAtual = AreaGeometrica.areaquadrado(num1, num2);
    Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [TestCase(10,7,70)]
    [TestCase(10,9,80)]
    [TestCase(10,8,30)]    
     public void testParalelogramoTC(int num1, int num2, int resultadoEsperado)
   {
    Assert.That(AreaGeometrica.areaparalelogramo(num1, num2), Is.EqualTo(resultadoEsperado));
    }

    [Test, TestCaseSource("lerDadosDeTeste", new object[] {"T"})]
    public void testTrianguloDD(int num1, int num2, int num3, int resultadoEsperado)
    {
    Assert.That(AreaGeometrica.areatriangulo(num1, num2, num3), Is.EqualTo(resultadoEsperado));
    
    }
  
}