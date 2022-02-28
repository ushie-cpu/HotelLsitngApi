using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Models.Dtos
{
    public class HotelDTO
    {
        public class CreateHotelDTO
        {
            [Required]
            [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
            public string Name { get; set; }
            [Required]
            [StringLength(maximumLength: 50, ErrorMessage = "Short Country Name Is too Long")]
            public string Address { get; set; }
            [Required]
            [Range(1,5)]
            public double Rating { get; set; }
            [Required]
            public int CountryId { get; set; }

        }

        public class HotelDTOs:CreateHotelDTO
        {
            public int Id{ get; set; }
            public CountryDTO Country { get; set; }
        }
    }
}
