using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DaoLayer.StudentDAO dao = new DaoLayer.StudentDAO();
            Assert.AreEqual(dao.getStudentRecordsNums(), 84);
        }
    }
}
