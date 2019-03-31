using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICategoryRepo
    {
        /// <summary>
        /// összes kategória lekérése
        /// </summary>
        /// <returns></returns>
        ICollection<ICategoryDTO> GetCategories();
        /// <summary>
        /// 1 termék alapján a kategória lekérése
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        ICollection<ICategoryDTO> GetCategories(int prodId);
        /// <summary>
        /// több termék alapján a kategória lekérése
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        ICollection<ICategoryDTO> GetCategories(List<int> prodId);
        /// <summary>
        /// új kategóriák felvétele
        /// </summary>
        /// <param name="categories"></param>
        void AddCategories(ICollection<ICategoryDTO> categories);
    }
}
