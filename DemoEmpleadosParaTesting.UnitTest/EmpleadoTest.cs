using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DemoEmpleadosParaTesting;
using NUnit.Framework;

namespace DemoEmpleadosParaTesting.UnitTest
{
    [TestFixture]
    public class EmpleadoTest
    {
        public EmpleadoTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private NUnit.Framework.TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public NUnit.Framework.TestContext TestContext
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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Test]
        /*public void SubirSueldo_Scenario_ExpectedBehavior()
        {
            //Arrange
            var emple = new Empleado();
            emple.Sueldo = 100;

            //Act
            emple.SubirSueldo(50);

            //Asserty
            Assert.That(emple.Sueldo, Is.EqualTo(150));
            
        }*/

        public void BajarSueldo_Scenario_ExpectedBehavior() {
            //Arrage
            var emple = new Empleado();
            emple.Sueldo = 100;

            //Act
            emple.BajarSueldo(4,20);

            //Assert
            Assert.That(emple.Sueldo, Is.EqualTo(80));
        }
    }
}
