namespace Calculadora.Testes
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
        }

        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
        }

        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
        }

        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Dividir(10, 10));
        }
    }
}
