using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp calc;

    public CalculadoraTestes()
    {
        calc = new CalculadoraImp();
    }
    [Fact]
    public void Somar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro(){
        // Arrange
        int numero = 4;

        //Act
        bool resultado = calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2,4,6})]
    [InlineData(new int[] {4, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros){
        //Arrang /Assert
        Assert.All(numeros, x => Assert.True(calc.EhPar(x)));
    }
}