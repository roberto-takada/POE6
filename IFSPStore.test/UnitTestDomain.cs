using System.Diagnostics;
using System.Text.Json;
using IFSPStore.domain.Entities;

namespace IFSPStore.test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");
            Debug.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Nome, "Birigui");
        }

        [TestMethod]
        public void TestGrupo()
        {
            Grupo grupo = new Grupo(1, "Vestimenta");
            Debug.WriteLine(JsonSerializer.Serialize(grupo));
            Assert.AreEqual(grupo.Nome, "Vestimenta");
        }

        [TestMethod]
        public void TestUsuario() {
        }
    }
}