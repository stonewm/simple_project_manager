using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data;
using MySql.Data.MySqlClient;
using StoneUtils;

namespace UnitTestProject
{
    [TestClass]
    public class TestDbUtils
    {
        [TestMethod]
        public void TestConnection()
        {
            MySqlConnection conn = DbUtils.GetConnection();

            try
            {
                conn.Open();
                Console.WriteLine("Successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                conn.Close();
            }
        }
    }
}
