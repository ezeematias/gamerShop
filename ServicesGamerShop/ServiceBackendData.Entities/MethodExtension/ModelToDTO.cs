using ServiceBackendData.Entities.ClassEntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.MethodExtension
{
    public static class ModelToDTO
    {
        public static ProductDTO ToDTO(this Product model)
        {
            return new ProductDTO
            {
                IdProduct = model.IdProduct,
                Name = model.Name,
                Brand = model.Brand,
                Stock = model.Stock,
                Price = model.Price,
                Available = model.Available,
                Description = model.Description,
                Images = model.ImageProduct.Select(x=> x.ToDTO())
            };
        }

        public static ImageProductDTO ToDTO(this ImageProduct model)
        {
            return new ImageProductDTO
            {
                IdImageProduct = model.IdImageProduct,
                IsMain = model.IsMain,
                Url = model.Url
            };
        }
    }
}
