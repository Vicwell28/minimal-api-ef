using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace minimal_api_ef.Models
{
    // [Table("Category")]
    public class Category
    {
        // [Key]
        public Guid CategoryId { get; set; }

        // [Required]
        // [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // [DataType(DataType.DateTime)]
        public DateTime Create_at { get; set; }
        public int Peso { get; set; }


        public virtual ICollection<TaskApi> tasks { get; set; }
    }
}