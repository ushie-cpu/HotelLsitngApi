using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Models.Dtos
{
    public class CountryDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength (maximumLength:50,ErrorMessage ="Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:50, ErrorMessage ="Short Country Name Is too Long")]
        public string  ShortName { get; set; }

    }

    public class CreateCountryDTO:CountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

     

    }
}
