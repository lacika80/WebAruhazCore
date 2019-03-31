using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IProductRepo
    {
        /// <summary>
        /// összes lekérése
        /// </summary>
        /// <returns></returns>
        List<IProductDTO> GetAllProduct();
        /// <summary>
        /// 1-nek a lekérése product id alapján
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        IProductDTO GetAllProduct(int prodId);
        void UploadProduct(IProductDTO product);
        /// <summary>
        /// Termék inaktivvá tétele
        /// </summary>
        /// <param name="prodId"></param>
        void DeleteProduct(int prodId);
        /// <summary>
        /// Termék Módosítása
        /// </summary>
        /// <param name="Product"></param>

        void ModifyProduct(IProductDTO Product, int prodId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prodId"></param>
        /// <param name="netPrice"></param>
        void ChangePrice(int prodId, decimal brutPrice);
    }
}
