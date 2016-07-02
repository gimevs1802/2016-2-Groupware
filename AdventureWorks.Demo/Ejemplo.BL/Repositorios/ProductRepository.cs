using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.Model;
using GenericRepository;

namespace Ejemplo.BL.Repositorios
{
    public class ProductRepository
    {
        public IQueryable <Product> GetAllByColor (
                IRepository<Product> productRepository, string colorName)
        {
            return productRepository.FindBy(x => x.Color == colorName);
        }
    }
}
