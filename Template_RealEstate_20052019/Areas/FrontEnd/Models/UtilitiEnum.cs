using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Extensions;

namespace Template_RealEstate_20052019.Areas.FrontEnd.Models
{
    public enum UtilitiEnum
    {
        [Description("Trường học")]
        [Symbol(ClassName = "fas fa-school")]
        School, //0
        [Description("Bệnh viện")]
        [Symbol(ClassName = "fas fa-hospital")]
        Hospital,//1
        [Description("Trung tâm thương mại")]
        [Symbol(ClassName = "fas fa-shopping-cart")]
        Mall,//2
        [Description("Hồ bơi")]
        [Symbol(ClassName = "fas fa-swimmer")]
        Pool,//3
        [Description("Công viên")]
        [Symbol(ClassName = "fas fa-tree")]
        Park,//4
        [Description("Sân thể thao")]
        [Symbol(ClassName = "fas fa-running")]
        SportField,//5
        [Description("Bến xe")]
        [Symbol(ClassName = "fas fa-bus-alt")]
        Station,//6
        [Description("Rạp chiếu phim")]
        [Symbol(ClassName = "fas fa-film")]
        Cinema//7
    }
}
