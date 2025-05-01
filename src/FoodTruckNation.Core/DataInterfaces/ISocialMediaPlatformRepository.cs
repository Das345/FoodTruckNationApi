using FoodTruckNation.Core.Domain;
using System.Collections.Generic;

namespace FoodTruckNation.Core.DataInterfaces
{
    public interface ISocialMediaPlatformRepository
    {

        List<SocialMediaPlatform> GetSocialMediaPlatforms();

        SocialMediaPlatform GetSocialMediaPlatform(int platformId);

    }
}
