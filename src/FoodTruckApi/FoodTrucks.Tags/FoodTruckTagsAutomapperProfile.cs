using AutoMapper;
using FoodTruckNation.Core.Domain;
using System;

namespace FoodTruckNationApi.Api.FoodTrucks.Tags
{
    /// <summary>
    /// Profile for mapping FoodTruckTag entities to their corresponding models
    /// </summary>
    public class FoodTruckTagsAutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodTruckTagsAutoMapperProfile"/> class
        /// and configures the mapping profiles.
        /// </summary>
        public FoodTruckTagsAutoMapperProfile()
        {
            AddFoodTruckToFoodTruckModelMap();
        }

        /// <summary>
        /// Configures the mapping from <see cref="FoodTruckTag"/> to <see cref="string"/>.
        /// </summary>
        internal void AddFoodTruckToFoodTruckModelMap()
        {
            CreateMap<FoodTruckTag, string>()
                .ConvertUsing(x => x.Tag.Text);
        }
    }
}
