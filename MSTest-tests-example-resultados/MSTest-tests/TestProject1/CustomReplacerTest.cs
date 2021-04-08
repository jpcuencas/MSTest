using MSTest_tests_example.Basics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for CustomReplacerTest and is intended
    ///to contain all CustomReplacerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomReplacerTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod1()
        {
            //delcaracion
            String cadena = null;
            String caracter = null;

            //actuacion
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }

        [TestMethod]
        public void TestMethod2()
        {
            String cadena = "hola";
            String caracter = "b";
            String esperado = "0";
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);

            Assert.AreEqual(esperado, res);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod3()
        {
            String cadena = null;
            String caracter = "a";
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod4()
        {
            String cadena = "hola";
            String caracter = null;
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod5()
        {
            String cadena = "hola";
            String caracter = "aa";
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod6()
        {
            String cadena = null;
            String caracter = "aa";
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }


        [TestMethod]
        public void TestMethod7()
        {
            String cadena = "holaa";
            String caracter = "a";
            String esperado = "hol12";
            CustomReplacer claseObjeto = new CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);

            Assert.AreEqual(esperado, res);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod8()
        {
            String cadena = null;
            String caracter = "";
            MSTest_tests_example.Basics.CustomReplacer claseObjeto = new MSTest_tests_example.Basics.CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestMethod9()
        {
            String cadena = "";
            String caracter = null;
            MSTest_tests_example.Basics.CustomReplacer claseObjeto = new MSTest_tests_example.Basics.CustomReplacer();

            var res = claseObjeto.CustomReplace(cadena, caracter);
        }
    }
}
