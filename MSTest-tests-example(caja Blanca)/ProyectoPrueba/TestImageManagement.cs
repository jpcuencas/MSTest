using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MSTest_tests_example;
using MSTest_tests_example.Mocks.Date;


namespace ProyectoPrueba
{
    namespace MSTest_tests_example.Mocks.Date
    {  

    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
        [TestClass]
        public class TestImageManagement
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
            ///A test for GetImageForTimeOfDay
            ///</summary>
            [TestMethod()]
            public void GetImageForTimeOfDayTest()
            {
                var imangeManagementMock = new Mock<ImageManagement>();
                imangeManagementMock.CallBase = true;
                imangeManagementMock.Setup(dat => dat.GetHour()).Returns(5);
                string expected = "moon.jpg";
                string actual;

                actual = imangeManagementMock.Object.GetImageForTimeOfDay();

                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            ///A test for GetImageForTimeOfDay
            ///</summary>
            [TestMethod()]
            public void GetImageForTimeOfDayTest_2Metodo()
            {
                var dateMock = new Mock<IDate>();
                dateMock.Setup(dat => dat.GetHour()).Returns(12);
                string expected = "sun.jpg";
                string actual;

                ImageManagement_2Metodo imageManagement = new ImageManagement_2Metodo();
                actual = imageManagement.GetImageForTimeOfDay(dateMock.Object);

                Assert.AreEqual(expected, actual);
            }


            public interface IClock
            {

                DateTime hora;
                int dia;
                int hr;

                void setHour(int h)
                {
                    hr = h;
                }

                int getHour()
                {
                   return hr;
                }

                void setTime(DateTime h)
                {
                    hora = h;
                }

                void setDate(int d)
                {
                    dia = d;
                }
                DateTime getTime()
                {
                    return hora;
                }

                int getDate()
                {
                    return dia;
                }
            }

            private readonly IClock reloj;

            //mayor de las 6 menos que 21
            [TestMethod]
            public void TestMethod1()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = 10;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

                Assert.AreEqual("sun.jpg", res);

            }

            //menor de las 6 mayor que 21
            [TestMethod]
            public void TestMethod2()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = 22;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

                Assert.AreEqual("moon.jpg", res);

            }

            // 6
            [TestMethod]
            public void TestMethod3()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = 6;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

                Assert.AreEqual("moon.jpg", res);

            }

            // 21
            [TestMethod]
            public void TestMethod4()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = 21;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

                Assert.AreEqual("moon.jpg", res);

            }

            // negativo
            [TestMethod, ExpectedException(typeof(Exception))]
            public void TestMethod5()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = -3;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

                

            }

            // mas de 24
            [TestMethod, ExpectedException(typeof(Exception))]
            public void TestMethod6()
            {
                ImageManagement imagen = new ImageManagement();

                String res = "";
                int hour = 30;
                reloj.setHour(hour);


                res = imagen.GetImageForTimeOfDay();

               

            }
        }
        
    }
}
