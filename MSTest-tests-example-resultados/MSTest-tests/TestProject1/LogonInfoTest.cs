using MSTest_tests_example.Private;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for LogonInfoTest and is intended
    ///to contain all LogonInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogonInfoTest
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


        /// <summary>
        ///A test for IsValidPassword
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MSTest-tests-example.dll")]
        public void IsValidPasswordTest()
        {
            string value = "1235Aa_4"; 
            string errorMessage = String.Empty;
            bool expected = true; 
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool) logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }

        //falta de minusculas
        [TestMethod]
        public void TestMethod1()
        {
            string value = "1235AA_4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de mayusculas
        [TestMethod]
        public void TestMethod2()
        {
            string value = "1235aa_4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de numeros
        [TestMethod]
        public void TestMethod3()
        {
            string value = "HHKKAA_a";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }

        //falta de simbolo
        [TestMethod]
        public void TestMethod4()
        {
            string value = "1235aAAB4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de minusculas y mayusculas
        [TestMethod]
        public void TestMethod5()
        {
            string value = "12355_4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }

        //falta de minusculas y numeros
        [TestMethod]
        public void TestMethod6()
        {
            string value = "DDDDA_B";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de mayusculas y numeros
        [TestMethod]
        public void TestMethod7()
        {
            string value = "dddda_f";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de minusculas y simbolos
        [TestMethod]
        public void TestMethod8()
        {
            string value = "1235ASS4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de mayusculas y simbolos
        [TestMethod]
        public void TestMethod9()
        {
            string value = "gg123aa4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de minusculas simbolos y numeros
        [TestMethod]
        public void TestMethod10()
        {
            string value = "AAAAAAAA";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //falta de mayusculas simbobolos y numeros
        [TestMethod]
        public void TestMethod11()
        {
            string value = "aaaaaaaa";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //longitud
        [TestMethod]
        public void TestMethod12()
        {
            string value = "12";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
        //espacios en blanco
        [TestMethod]
        public void TestMethod13()
        {
            string value = "1235Aa _4";
            string errorMessage = String.Empty;
            bool expected = false;
            bool actual;
            PrivateType logonInfo = new PrivateType(typeof(LogonInfo));
            actual = (bool)logonInfo.InvokeStatic("IsValidPassword", value, errorMessage);

            Assert.AreEqual(expected, actual);
        }
    }
}
