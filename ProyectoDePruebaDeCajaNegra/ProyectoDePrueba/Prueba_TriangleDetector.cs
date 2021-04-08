using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleDetector;

namespace ProyectoDePrueba
{
    [TestClass]
    public class Prueba_TriangleDetector
    {
        /**
         * Para sustituir [TestMethod, ExpectedException(typeof(ArgumentException))]
         [TestMethod]
        public void Prueba_EsTriangulo1()
        {
         try{
         ...
         asert.fail;
         } 
         cacth()
         {}
          
         }
         **/
        [TestMethod]
        public void Prueba_EsTriangulo4()
        {
            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = 1;
            int lado3 = 1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
            Assert.AreEqual(TriangleDetector.TriangleValidator.EQUILATERO, res);

        }

        [TestMethod]
        public void Prueba_EsTriangulo5()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = 2;
            int lado3 = 3;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
            Assert.AreEqual(TriangleDetector.TriangleValidator.ESCALENO, res);
        }
        [TestMethod]
        public void Prueba_EsTriangulo6()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = 2;
            int lado3 = 2;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
            Assert.AreEqual(TriangleDetector.TriangleValidator.ISOSCELES, res);
        }
  



        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo10()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = -1;
            int lado2 = -1;
            int lado3 = -1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo11()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = -1;
            int lado2 = -1;
            int lado3 = 1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo12()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = -1;
            int lado2 = 1;
            int lado3 = -1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo13()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = -1;
            int lado3 = -1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo14()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 0;
            int lado2 = 1;
            int lado3 = 1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo15()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = 0;
            int lado3 = 1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo16()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 1;
            int lado2 = 1;
            int lado3 = 0;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo17()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

        //lados inconclusos
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Prueba_EsTriangulo18()
        {

            /**
             * Declaracion de objetos
             * Planificar
             **/
            TriangleDetector.TriangleValidator triangulo = new TriangleDetector.TriangleValidator();
            int lado1 = 8;
            int lado2 = 2;
            int lado3 = 1;

            /**
             * Realizar Acciones
             * Actuar
             **/
            var res = triangulo.EsTriangulo(lado1, lado2, lado3);


            /**
             * Revisar Resultados
             * Comprobar
             **/
        }

    }
}
