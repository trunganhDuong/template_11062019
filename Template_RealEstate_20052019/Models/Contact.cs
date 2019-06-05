using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Hãy nhập ít nhất 4 ký tự")]
        [MaxLength(255, ErrorMessage = "Hãy nhập nhiều nhất 255 ký tự")]
        public string Name { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Hãy nhập ít nhất 10 ký tự")]
        [MaxLength(11, ErrorMessage = "Hãy nhập nhiều nhất 11 ký tự")]
        [RegularExpression(@"0[0-9]{9,10}", ErrorMessage = "Hãy nhập đúng định dạng điện thoại")]
        public string Phone { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Hãy nhập nhiều nhất 255 ký tự")]
        [RegularExpression(@"[^\s()<>@,;:\/]+@\w[\w\.-]+\.[a-z]{2,}", ErrorMessage = "Hãy nhập đúng định dạng điện thoại")]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
