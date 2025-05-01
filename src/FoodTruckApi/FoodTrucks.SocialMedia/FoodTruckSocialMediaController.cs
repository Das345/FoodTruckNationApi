using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using FoodTruckNation.Core.AppInterfaces;
using DavidBerry.Framework.ApiUtil.Controllers;
using FoodTruckNation.Core.Domain;
using DavidBerry.Framework.ApiUtil.Models;

namespace FoodTruckNationApi.Api.FoodTrucks.SocialMedia
{
    /// <summary>
    /// API Controller to get/add/update social media accounts for a food truck
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="FoodTruckSocialMediaController"/> class.
    /// </remarks>
    /// <param name="logger">The logger instance.</param>
    /// <param name="mapper">The mapper instance.</param>
    /// <param name="foodTruckService">The food truck service instance.</param>
    [Produces("application/json")]
    [Route("api/FoodTrucks/{foodTruckId}/SocialMediaAccounts")]
    [ApiVersion("1.1")]
    public class FoodTruckSocialMediaController(ILogger<FoodTruckSocialMediaController> logger, IMapper mapper, IFoodTruckService foodTruckService) : ApiControllerBase(logger, mapper)
    {
        private readonly IFoodTruckService _foodTruckService = foodTruckService;

        internal const string GET_FOOD_TRUCK_SOCIAL_ACCOUNTS = "GetFoodTruckSocialMediaAccounts";

        internal const string GET_FOOD_TRUCK_SOCIAL_ACCOUNT_BY_ID = "GetFoodTruckSocialMediaAccountById";

        /// <summary>
        /// Gets the list of social media accounts for this food truck.
        /// </summary>
        /// <param name="foodTruckId">The id number of this food truck.</param>
        /// <returns>A list of social media accounts.</returns>
        /// <response code="200">Success. A list of the current social media accounts for the food truck is returned.</response>
        /// <response code="404">Not Found. No food truck could be found for this id.</response>
        /// <response code="500">Internal Server Error. An unexpected problem occurred on the server occurred. The error has been logged by the server.</response>
        [HttpGet(Name = "GetFoodTruckSocialMediaAccounts")]
        [ProducesResponseType(typeof(List<SocialMediaAccount>), 200)]
        [ProducesResponseType(typeof(ApiMessageModel), 404)]
        [ProducesResponseType(typeof(ApiMessageModel), 500)]
        public IActionResult Get(int foodTruckId)
        {
            var result = _foodTruckService.GetFoodTruck(foodTruckId);

            if (result.IsSuccess)
            {
                var models = _mapper.Map<List<SocialMediaAccount>, List<SocialMediaAccountModelV11>>(result.Value.SocialMediaAccounts);
                return Ok(models);
            }
            else
            {
                return MapErrorResult<List<SocialMediaAccount>, List<SocialMediaAccountModelV11>>(result);
            }
        }

        // Other methods remain unchanged
    }
}
