using System;

namespace FoodTruckNationApi.Api.FoodTrucks.SocialMedia
{
    /// <summary>
    /// Represents a social media account associated with a food truck.
    /// </summary>
    public class SocialMediaAccountModelV11
    {
        /// <summary>
        /// Gets or sets the name of the social media platform (e.g., Twitter, Facebook).
        /// </summary>
        public string PlatformName { get; set; }

        /// <summary>
        /// Gets or sets the account name or handle on the social media platform.
        /// </summary>
        public string AccountName { get; set; }
    }
}
