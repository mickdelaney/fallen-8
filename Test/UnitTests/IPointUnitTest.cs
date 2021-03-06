﻿#region Usings

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoSQL.GraphDB.Index.Spatial;

#endregion

namespace NoSQL.GraphDB.Test
{
    
    
    /// <summary>
    ///This is a test class for IPointUnitTest and is intended
    ///to contain all IPointUnitTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IPointUnitTest
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


        internal virtual IPoint CreateIPoint()
        {
            // TODO: Instantiate an appropriate concrete class.
            IPoint target = null;
            return target;
        }

        /// <summary>
        ///A test for PointToSpaceR
        ///</summary>
        [TestMethod()]
        public void PointToSpaceRUnitTest()
        {
            Assert.Inconclusive("TODO");

            IPoint target = CreateIPoint(); // TODO: Initialize to an appropriate value
            float[] expected = null; // TODO: Initialize to an appropriate value
            float[] actual;
            actual = target.PointToSpaceR();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Coordinates
        ///</summary>
        [TestMethod()]
        public void CoordinatesUnitTest()
        {
            Assert.Inconclusive("TODO");

            IPoint target = CreateIPoint(); // TODO: Initialize to an appropriate value
            IEnumerable<object> actual;
            actual = target.Coordinates;
        }
    }
}
