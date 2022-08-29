using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("Projects")]
    internal class Project
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName ="char")]
        public string ProjectId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; }
    }
}
