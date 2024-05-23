using System;
using Xunit;
using Calculadora;

namespace TestCalculadora
{
    public class UnitTest1
    {

        public ClassCalculadora construirClasse()
        {
            string data = "23/05/2024";
            ClassCalculadora Calc = new ClassCalculadora(data);

            return Calc;
        }

        [Theory] 
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)     
        {
            ClassCalculadora calc = construirClasse();

            int retorno = calc.Somar(val1, val2);

            Assert.Equal(res, retorno);
        }
        
        [Theory] 
        [InlineData(3, 2, 1)]
        [InlineData(9, 5, 4)]
        public void TesteSubtrair(int val1, int val2, int res)     
        {
            ClassCalculadora calc = construirClasse();

            int retorno = calc.Subtrair(val1, val2);

            Assert.Equal(res, retorno);
        }

        [Theory] 
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)     
        {
            ClassCalculadora calc = construirClasse();

            int retorno = calc.Multiplicar(val1, val2);

            Assert.Equal(res, retorno);
        }
        
        [Theory] 
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int val1, int val2, int res)     
        {
            ClassCalculadora calc = construirClasse();

            int retorno = calc.Dividir(val1, val2);

            Assert.Equal(res, retorno);
        }

        [Fact]
        public void TesteDividirPorZero()
        {
            ClassCalculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
        
        [Fact]
        public void TesteHistorico()
        {
            ClassCalculadora calc = construirClasse();

            calc.Somar(1, 3);
            calc.Somar(5, 3);
            calc.Somar(12, 3);
            calc.Somar(12, 21);

            var result = calc.Historico();

            Assert.NotEmpty(result);  
            Assert.Equal(3, result.Count);
        }

    }
}
