using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaVehiculos.Classes;
using Tests.NH;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestVarios()
        {
            var session = Helper.GetSession();

            for (int i = 200; i < 250; i++)
            {
                var tutu = new Automovil();
                tutu.TieneAirbag = ((i % 2) == 0);
                tutu.Patente = "AAA" + i.ToString();
                session.Save(tutu);
            }


            for (int i = 100; i < 150; i++)
            {
                var moto = new Moto();
                moto.TieneMonoshock = ((i % 2) == 0);
                moto.Patente = "AAA" + i.ToString();
                session.SaveOrUpdate(moto);
            }

            session.Flush();
            session.Close();
        }
    }
}
