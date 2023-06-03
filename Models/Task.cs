using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api_ef.Models
{
    [Table("Task")]
    public class TaskApi
    {
        [Key]
        public Guid TaskApiId { get; set; }

        [ForeignKey("CategoryId")]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Priority Priority { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Create_at { get; set; }

        public virtual Category Catrgory { get; set; }

        [NotMapped]
        public string Resumen { get; set; } = string.Empty;

    }

    public enum Priority
    {
        Baja,
        Media,
        Alta
    }

}