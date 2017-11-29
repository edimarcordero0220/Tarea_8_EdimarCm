using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class DiscoBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Discos disco = new Discos();
           Assert.IsTrue(DiscoBLL.Insertar(disco));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}