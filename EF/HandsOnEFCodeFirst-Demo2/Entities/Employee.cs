using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("Employees")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //remove the identity to EmployeeId
        public int EmployeeId { get; set; }
        [Required] //apply not null
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string EmployeeName { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? JoinDate { get; set; }
        [Required] //apply not null
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Designation { get; set; }
        public double? Salary { get; set; }
        [ForeignKey("Project")]
        public string ProjectId { get; set; }

        public Project Project { get; set; } //Navigation Property
    }
}
