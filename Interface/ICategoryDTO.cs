using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICategoryDTO
    {
        int CatId { get; set; }
        string CatName { get; set; }
        int CatsBoss { get; set; }
    }
}
