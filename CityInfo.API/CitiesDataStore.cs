using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Dublin",
                    Description = "City Centre"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Swords",
                    Description = "Biggest Town"
                }
            };
            ;
        }
    }
}
