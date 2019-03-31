using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    [Table("Item")]
    public class Filler
    {
        [Key()]
        public Guid ItemId { get; set; }
        public string Content { get; set; }
        public int No { get; set; }
    }
}
