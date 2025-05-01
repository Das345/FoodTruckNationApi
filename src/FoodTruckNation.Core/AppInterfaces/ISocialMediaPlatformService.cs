using FoodTruckNation.Core.Domain;
using DavidBerry.Framework.Functional;
using System.Collections.Generic;

namespace FoodTruckNation.Core.AppInterfaces
{
    public interface ISocialMediaPlatformService
    {

        Result<SocialMediaPlatform> GetSocialMediaPlatform(int platformId);

        Result<List<SocialMediaPlatform>> GetAllSocialMediaPlatforms();


    }
}
