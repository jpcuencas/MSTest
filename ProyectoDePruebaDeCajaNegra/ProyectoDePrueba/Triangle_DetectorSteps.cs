using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyectoDePrueba
{
    [Binding]
    public class Triangle_DetectorSteps
    {
        TriangleDetector.TriangleValidator triangulo;
        String resultadoActual;
        [Given(@"tengo validador de triangulos")]
        public void GivenTengoValidadorDeTriangulos()
        {
            triangulo = new TriangleDetector.TriangleValidator();
        }
        
        [When(@"Compruebo el tipo de triangulo de lado:(.*), (.*), (.*)")]
        public void WhenComprueboElTipoDeTrianguloDeLado(int p0, int p1, int p2)
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo(p0, p1, p2);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [When(@"Compruebo el tipo de triangulo de lado letra:a, a, (.*)")]
        public void WhenComprueboElTipoDeTrianguloDeLadoLetraAA(int p0)
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo('a', 'a', p0);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [When(@"Compruebo el tipo de triangulo de lado letra:b, a, (.*)")]
        public void WhenComprueboElTipoDeTrianguloDeLadoLetraBA(int p0)
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo('b', 'a', p0);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [When(@"Compruebo el tipo de triangulo de lado letra:a, b, c")]
        public void WhenComprueboElTipoDeTrianguloDeLadoLetraABC()
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo('a', 'b', 'c');
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [When(@"Compruebo el tipo de triangulo de lado letra:a, a, b")]
        public void WhenComprueboElTipoDeTrianguloDeLadoLetraAAB()
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo('a', 'a', 'b');
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [When(@"Compruebo el tipo de triangulo de lado letra:a, a, a")]
        public void WhenComprueboElTipoDeTrianguloDeLadoLetraAAA()
        {
            try
            {
                resultadoActual = triangulo.EsTriangulo('a', 'a', 'a');
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }

        }
        
        [Then(@"me devuelve el tipo equilatero")]
        public void ThenMeDevuelveElTipoEquilatero()
        {

            Assert.AreEqual(TriangleDetector.TriangleValidator.EQUILATERO, resultadoActual);
        }
        
        [Then(@"me devuelve el tipo escaleno")]
        public void ThenMeDevuelveElTipoEscaleno()
        {

            Assert.AreEqual(TriangleDetector.TriangleValidator.ESCALENO, resultadoActual);
        }
        
        [Then(@"me devuelve el tipo isorceles")]
        public void ThenMeDevuelveElTipoIsorceles()
        {

            Assert.AreEqual(TriangleDetector.TriangleValidator.ISOSCELES, resultadoActual);
        }
        
        [Then(@"me devuelve una excepcion de argumento")]
        public void ThenMeDevuelveUnaExcepcionDeArgumento()
        {
            Exception excepcion = (Exception)ScenarioContext.Current["Exception_triangle"];
            Assert.IsNotNull(excepcion);
            Assert.AreEqual("No es triangulo", excepcion.Message);
        }
    }
}
