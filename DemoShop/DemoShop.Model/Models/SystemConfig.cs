using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemCinfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Code { set; get; }
        [MaxLength(250)]
        public string ValueString { set; get; }
        public int? ValueInt { set; get; }
    }
}
