using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBBTimetable;
using System.Windows.Forms;
using SwissTransport;

namespace SBBTimetableUnitTest
{
    [TestClass]
    public class UnitTest
    {
        //Unit Test for Public Functions in SBBTimetable
        [TestMethod]
        public void getStationBoardTest()
        {
            //arrange
            MainForm mainFormTest = new MainForm();
            Transport transportTest = new Transport();
            //act
            var result = mainFormTest.GetStationBoard("Sursee");
            var expectedResult = transportTest.GetStationBoard("Sursee", "8502007");
            //assert
            Assert.AreNotEqual(result, expectedResult)
        }
    }
}
