using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejemplo.Model;

namespace Ejemplo.Tests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ConsultarProductosNegros()
        {
            // definir el escenario de la prueba
            string miColor = "Black";
            // repositorio
            var repositorio = new Ejemplo.BL.Repositorios.ProductRepository ();
            var context = new AdventureWorks2014Entities();
            // invocar al método correspondiente
            var resultado = repositorio.GetAllByColor(context.Products, miColor);
        }
    }
}
