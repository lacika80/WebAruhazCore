using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using System.Linq;

namespace DAL.Model.Repository
{
    public class FilterRepo
    {
        private readonly AruhazContext _ctx;
        public FilterRepo(AruhazContext ctx)
        {
            _ctx = ctx;
        }
        public void AddCategories(ICollection<IFilterDTO> filters)
        {
            throw new NotImplementedException();
        }

        public ICollection<IFilterDTO> getFilters()
        {
            throw new NotImplementedException();
        }

        public ICollection<IFilterDTO> getFilters(int prodId)
        {
            throw new NotImplementedException();
        }

        public ICollection<IFilterDTO> getFilters(List<int> prodId)
        {
            throw new NotImplementedException();
        }
    }
}
