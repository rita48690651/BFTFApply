namespace BFTFApply.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apply")]
    public partial class Apply
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "�m�W")]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "�����Ҧr��")]
        [RegularExpression(@"^[A-Z][1-2][0-9]{8}$", ErrorMessage = "�榡���~")]
        public string IdentityCardNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "�NŪ�Ǯ�")]
        public string School { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "�ӶU�z��")]
        public string Reason { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^09[0-9]{8}$", ErrorMessage = "�榡���~")]
        [Display(Name = "������X")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "�q�l�l��")]
        [EmailAddress(ErrorMessage = "{0} �榡���~")]
        public string Email { get; set; }

        [Display(Name = "�ӶU���B")]
        [Range(1000,100000,ErrorMessage ="���B�ݤ���1000�M100000����")]
        public int Money { get; set; }


        [Display(Name = "�b��")]
        public int UserId { get; set; }

        [Display(Name = "�Q�v")]
        [Range(1, 16, ErrorMessage = "�Q�v�ݤ���1�M16����")]
        public decimal Interest { get; set; }

    }
}
