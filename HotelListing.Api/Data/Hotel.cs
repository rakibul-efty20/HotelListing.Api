using System.ComponentModel.DataAnnotations;

namespace HotelListing.Api.Data
{
    public class Hotel
    {  
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
        public string? Country { get; set; }
    }
}
