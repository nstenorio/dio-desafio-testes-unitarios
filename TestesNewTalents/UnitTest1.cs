using System;
using Xunit;
using NewTalents;

namespace TestesNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string Data = "23/10/2023";
            Calculadora Calc = new Calculadora("23/10/2023");

            return Calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int Val1, int Val2, int Result)
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act
            int ResultCalculator = Calc.Somar(Val1, Val2);

            //Assert
            Assert.Equal(Result, ResultCalculator);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int Val1, int Val2, int Result)
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act
            int ResultCalculator = Calc.Multiplicar(Val1, Val2);

            //Assert
            Assert.Equal(Result, ResultCalculator);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(45, 5, 9)]
        public void TesteDividir(int Val1, int Val2, int Result)
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act
            int ResultCalculator = Calc.Dividir(Val1, Val2);

            //Assert
            Assert.Equal(Result, ResultCalculator);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int Val1, int Val2, int Result)
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act
            int ResultCalculator = Calc.Subtrair(Val1, Val2);

            //Assert
            Assert.Equal(Result, ResultCalculator);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(
                () => Calc.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            //Arrange
            Calculadora Calc = ConstruirClasse();

            //Act
            Calc.Somar(1, 2);
            Calc.Somar(2, 8);
            Calc.Somar(3, 7);
            Calc.Somar(4, 1);

            var Lista = Calc.Historico();

            //Assert
            Assert.NotEmpty(Lista);
            Assert.Equal(3, Lista.Count);
        }
    }
}