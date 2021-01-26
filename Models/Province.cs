using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Lab03.Models
{
    public class Province
    {
        [KeyAttribute]
        [DisplayNameAttribute("Province Code")]
        [Required]
        public string ProvinceCode { get; set; }
        [DisplayNameAttribute("Province")]
        [Required]
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}