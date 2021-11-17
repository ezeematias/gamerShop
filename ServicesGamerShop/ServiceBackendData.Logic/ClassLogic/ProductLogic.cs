using ServiceBackendData.Entities;
using ServiceBackendData.Entities.ClassEntitiesDTO;
using ServiceBackendData.Entities.MethodExtension;
using ServiceBackendData.Logic.InterfaceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Logic.ClassLogic
{
    public class ProductLogic : BaseLogic, ICRUDLogic<ProductDTO>, IGetLogic<Product>
    {
        public void Add(ProductDTO addItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Product;
        }

        public void Update(ProductDTO updateItem)
        {
            throw new NotImplementedException();
        }
    }
}
