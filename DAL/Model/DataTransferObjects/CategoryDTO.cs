using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    class CategoryDTO : Interfaces.ICategoryDTO
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public int CatsBoss { get; set; }
        public virtual ICollection<Filter2Product> Filter2Product { get; set; }
    }
}
