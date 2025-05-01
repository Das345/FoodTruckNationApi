using FoodTruckNation.Core.DataInterfaces;
using System.Collections.Generic;
using FoodTruckNation.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FoodTruckNation.Data.EF.Repositories
{
    public class SocialMediaPlatformRepository(FoodTruckContext context) : ISocialMediaPlatformRepository
    {
        private readonly FoodTruckContext _foodTruckContext = context;


        public SocialMediaPlatform GetSocialMediaPlatform(int platformId)
        {
            var platform = _foodTruckContext.SocialMediaPlatforms
                .FirstOrDefault(p => p.PlatformId == platformId);
                
            return platform;
        }

        public List<SocialMediaPlatform> GetSocialMediaPlatforms()
        {
            var platforms = _foodTruckContext.SocialMediaPlatforms
                .AsNoTracking()
                .ToList();

            return platforms;
        }
    }
}
