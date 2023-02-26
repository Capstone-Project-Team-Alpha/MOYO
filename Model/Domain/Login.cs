using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MOYO_Website.Model.Domain
{
    public class Login
    {
        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public int failedLoginAttempts { get; set; }

        public int status { get; set; }

        [Column(TypeName = "date")]
        public DateTime createDate { get; set; }
    }
}
