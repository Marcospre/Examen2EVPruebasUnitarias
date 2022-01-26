using Xunit;
using Metaverso;


namespace Metaverso
{

    public class SistemaTest
    {
        
        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }
        [Theory]
        [InlineData(3,"Meta")]
        [InlineData(10,"verso")]
        [InlineData(15,"Metaverso")]
        [InlineData(7,"7")]
        public void testMetaverso(int num, string esp){
            var sis=new Sistema();
            string res=sis.metaVerso(num);

            Assert.Equal(res,esp);
        }
        [Fact]
        public void testMetaArray()
        {
            // Given
            var sis=new Sistema();
            int[] valores={6,10,9,15,7};
            string esp="MetaversoMetaMetaverso7";
            // When
            var res=sis.metaArray(valores);
            // Then
            Assert.Equal(res,esp);
        }
    }
}