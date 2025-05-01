using AutoMapper;
using FoodTruckNation.Core.Commands;
using FoodTruckNation.Core.Domain;

namespace FoodTruckNation.Core.Mappers
{

    /// <summary>
    /// Class to define AutoMapper profiles for location related objects
    /// </summary>
    public class LocationMappingProfile : Profile
    {

        public LocationMappingProfile()
        {
            AddUpdateLocationCommandToLocationMap();
        }




        internal void AddUpdateLocationCommandToLocationMap()
        {
            CreateMap<UpdateLocationCommand, Location>();
        }

    }
}
