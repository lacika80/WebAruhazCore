using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using System.Linq;

namespace DAL.Model.Repository
{
    public class ProductRepo : Interfaces.IProductRepo
    {
        private readonly AruhazContext _ctx;
        public ProductRepo(AruhazContext ctx)
        {
            _ctx = ctx;
        }
        public void ChangePrice(int prodId, decimal brutPrice)
        {
            var prod = _ctx.Products.First(x => x.ProdId == prodId);
            prod.BrutPrice = brutPrice;
            prod.ProdPriceChanged = DateTime.UtcNow.Date;
            _ctx.SaveChanges();

        }

        public void DeleteProduct(int prodId)
        {
            var prod = _ctx.Products.First(x => x.ProdId == prodId);
            prod.IsActiveProd = false;
            _ctx.SaveChanges();
        }

        public List<IProductDTO> GetAllProduct()
        {
            List<IProductDTO> prods = new List<IProductDTO>();
            foreach (var item in _ctx.Products)
            {
                prods.Add(item);
            }
            return prods;
        }

        public IProductDTO GetAllProduct(int prodId)
        {
            return _ctx.Products.First(x => x.ProdId == prodId);
        }

        public void ModifyProduct(IProductDTO Product, int prodId)
        {
            var oprod = _ctx.Products.First(x => x.ProdId == Product.ProdId);
            oprod.ProdName = Product.ProdName;
            oprod.ProdDescription = Product.ProdDescription;
            oprod.IsActiveProd = Product.IsActiveProd;
            if (oprod.BrutPrice != Product.BrutPrice)
            {
                oprod.ProdPriceChanged  = DateTime.UtcNow.Date;
                oprod.BrutPrice = Product.BrutPrice;
            }
            oprod.VAT = Product.VAT;
            _ctx.SaveChanges();
        }

        public void UploadProduct(IProductDTO product)
        {
            Product p = new Product()
            {
                ProdName = product.ProdName,
                ProdDescription = product.ProdDescription,
                BrutPrice = product.BrutPrice,
                VAT = product.VAT
            };
            _ctx.Products.Add(p);
            _ctx.SaveChanges();
        }
    }
}
