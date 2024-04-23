using ModuloTestesDIO.Calculadora.Services;

namespace ModuloTestesDIO.CalculadoraTestes
{
    public class ValidacoesStringTests
    {

        private ValidacoesString _validacoes;
        public ValidacoesStringTests()
        {

            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveConta3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);

        }
    }
}