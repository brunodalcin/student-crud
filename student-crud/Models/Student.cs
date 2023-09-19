using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student_crud.Models {
    public class Student {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Age { get; set; }
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "This field is required.")]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage = "This field is required.")]
        public string College { get; set; }
        [Column(TypeName = "varchar(255)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Course { get; set; }

    }
}
