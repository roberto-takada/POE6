using MySql.Data.MySqlClient;

namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {

        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" + "uid=root;" + "pwd=teste123;" + "database=academico";
            var con = new MySqlConnection(c);
            return con;
        }
        [TestMethod]
        public void TestConnect()
        {
            string c = @"server=127.0.0.1;" + "uid=root;" + "pwd=teste123;" + "database=academico";
            var con = new MySqlConnection(c);
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }
        [TestMethod]
        public void TestInsert()
        {


        }
    }
}