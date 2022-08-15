using System.ComponentModel.DataAnnotations;

namespace mySmartWallet2022.Models.Data.Entities
{
    public class Country : baseClass
    {
        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string continent { set; get; }

        [Required]
        [MaxLength(4)]
        public string zipCode { set; get; }
    }
}
