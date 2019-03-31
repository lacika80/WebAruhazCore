using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Filter")]
    public class Filter
    {
        [Key()]
        public int FId { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public int FsBoss { get; set; }

        public virtual ICollection<Filter2Product> Filter2Product { get; set; }
    }
}
