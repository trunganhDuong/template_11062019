using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Models
{
    public class Utility
    {
        [Required(ErrorMessage = "Bạn cần chọn loại tiện ích")]
        [Display(Name = "Loại tiện ích")]
        public UtilitiEnum Type { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        public int UtilityId { get; set; }
    }
}
