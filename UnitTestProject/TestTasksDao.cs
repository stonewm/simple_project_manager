using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProjectManager;

namespace UnitTestProject
{
    [TestClass]
    public class TestTasksDao
    {
        [TestMethod]
        public void TestListAll()
        {
            var tasksDao = new PrjTasksDao();
            var tasks = tasksDao.ListAll();

            Console.WriteLine("OK");
        }
    }
}
