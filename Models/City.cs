using System.ComponentModel;
namespace Lab03.Models
{
    public class City
    {
        public int CityId { get; set; }
        [DisplayNameAttribute("City")]
        public string CityName { get; set; }
        public int Population { get; set; }
        public string Province { get; set; }
    }
}