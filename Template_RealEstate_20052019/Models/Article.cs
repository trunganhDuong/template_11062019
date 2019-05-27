using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string ArticleTitle { get; set; }

        public string Sapo { get; set; }

        public string Content { get; set; }

        public string Avatar { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
