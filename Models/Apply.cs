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
        [Display(Name = "姓名")]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "身分證字號")]
        [RegularExpression(@"^[A-Z][1-2][0-9]{8}$", ErrorMessage = "格式有誤")]
        public string IdentityCardNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "就讀學校")]
        public string School { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "申貸理由")]
        public string Reason { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^09[0-9]{8}$", ErrorMessage = "格式有誤")]
        [Display(Name = "手機號碼")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "電子郵件")]
        [EmailAddress(ErrorMessage = "{0} 格式有誤")]
        public string Email { get; set; }

        [Display(Name = "申貸金額")]
        [Range(1000,100000,ErrorMessage ="金額需介於1000和100000之間")]
        public int Money { get; set; }


        [Display(Name = "帳號")]
        public int UserId { get; set; }

        [Display(Name = "利率")]
        [Range(1, 16, ErrorMessage = "利率需介於1和16之間")]
        public decimal Interest { get; set; }

    }
}
