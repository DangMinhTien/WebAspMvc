using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Bai1_ChinhThuc.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [DisplayName("Họ tên")]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Phải là Email")]
        public string Email { get; set; }
        public DateTime DateSent { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(1000)]
        [Required]
        public string Message { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Phải nhập số điện thoại")]
        [Phone(ErrorMessage = "Phải nhập số điện thoại")]
        public string Phone { get; set; }
    }
}
