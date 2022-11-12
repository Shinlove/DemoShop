using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(250)]
        public string Name { set; get; }

        public string Content { set; get; }
        [MaxLength(250)]
        public string MetaKeyword { set; get; }
        [MaxLength(250)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}
