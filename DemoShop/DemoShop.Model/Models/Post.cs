using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DemoShop.Model.Abstract;

namespace DemoShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
        [MaxLength(500)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int? ViewCount { set; get; }
    }
}
