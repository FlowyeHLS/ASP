using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "BezFamililii nikak........")]
        [StringLength(50, ErrorMessage = "Abrakadabra") ]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "BezImeni nikak........")]
        [StringLength(50, ErrorMessage = "Abrakadabra")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //nav props

    }
}
