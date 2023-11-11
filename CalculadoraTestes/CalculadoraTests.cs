using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(15, 15, 30)]
    [InlineData(100, 100, 200)]
    public void DeveReceberDoisValoresERetornarASoma(int num1, int num2, int resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, _calc.Somar(num1, num2));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, -1)]
    [InlineData(15, 15, 0)]
    [InlineData(100, 150, -50)]
    public void DeveReceberDoisValoresERetornarASubtração(int num1, int num2, int resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, _calc.Subtrair(num1, num2));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 2)]
    [InlineData(15, 15, 225)]
    [InlineData(100, 100, 10000)]
    public void DeveReceberDoisValoresERetornarAMultiplicacao(int num1, int num2, int resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, _calc.Multiplicar(num1, num2));
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(15, 15, 1)]
    [InlineData(1100, 100, 11)]
    public void DeveReceberDoisValoresERetornarADivisao(int num1, int num2, int resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, _calc.Dividir(num1, num2));
    }

    [Fact]
    public void DeveReceberUmaDivisaoPorZeroERetornarUmaExcecao()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void DeveRealizar4OperacoesERetornarOHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Subtrair(8, 2);
        _calc.Dividir(6, 3);
        _calc.Multiplicar(4, 1);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(4, lista.Count);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6})]
    [InlineData(new int[] {8, 10, 12})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}