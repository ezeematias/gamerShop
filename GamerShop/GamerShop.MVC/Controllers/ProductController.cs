using GamerShop.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerShop.MVC.Controllers
{
    public class ProductController : Controller
    {
        ServiceGamerShop.ServiceClient client = new ServiceGamerShop.ServiceClient();
        // GE.T: Product
        public ActionResult Index()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            var list = client.GetAll();
            foreach (var item in list)
            {
                ProductDTO auxProduct = new ProductDTO
                {
                    IdProduct = item.IdProduct,
                    Name = item.Name,
                    Brand = item.Brand,
                    Stock = item.Stock,
                    Reference = item.Reference,
                    Price = item.Price,
                    Description = item.Description,
                    Available = item.Available,
                    Images = new List<ImageProductDTO>()
                };
                foreach (var itemImage in item.Images)
                {
                    ImageProductDTO auxImage = new ImageProductDTO
                    {
                        IdImageProduct = itemImage.IdImageProduct,
                        IdProduct = itemImage.IdProduct,
                        IsMain = itemImage.IsMain,
                        Url = itemImage.Url                        
                    };
                    auxProduct.Images.Add(auxImage);
                }
                products.Add(auxProduct);
            }
            return View(products);
        }
    }
}