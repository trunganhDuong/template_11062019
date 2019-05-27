using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tiêu đề")]
        [MinLength(5, ErrorMessage = "Độ dài tối thiểu 5 ký tự")]
        [MaxLength(255, ErrorMessage = "Độ dài tối đa 255 ký tự")]
        [Display(Name = "Tiêu đề bài viết")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập sapo")]
        [MinLength(5, ErrorMessage = "Độ dài tối thiểu 5 ký tự")]
        [MaxLength(1024, ErrorMessage = "Độ dài tối đa 1024 ký tự")]
        [Display(Name = "Sapo bài viết")]
        public string Sapo { get; set; }
        
        [Required(ErrorMessage = "Bạn cần nhập nội dung")]
        [MinLength(30, ErrorMessage = "Độ dài tối thiểu 30 ký tự")]
        [Display(Name = "Nội dung bài viết")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
