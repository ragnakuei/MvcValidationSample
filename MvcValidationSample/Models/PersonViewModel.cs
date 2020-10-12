using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcValidationSample.Models
{
    public class PersonViewModel
    {
        [Display(Name             = "編號")]
        [Required(ErrorMessage    = "{0} 為必填")]
        [Range(2, 5, ErrorMessage = "{0} 數值 要介於 {1} 及 {2} 之間")]
        public int? Id { get; set; }

        [Display(Name = "名稱")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage         = "請輸入{0}")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "{0} 長度 要介於 {2} 及 {1} 之間")]
        public string Name { get; set; }

        [Display(Name = "電子信箱")]
        [Required(ErrorMessage     = "{0} 為必填")]
        [EmailAddress(ErrorMessage = "{0} 格式錯誤")]
        public string Email { get; set; }
    }
}
