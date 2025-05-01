using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DavidBerry.Framework.ApiUtil.Controllers;
using FoodTruckNation.Core.AppInterfaces;
using DavidBerry.Framework.TimeAndDate;
using Microsoft.Extensions.Logging;
using AutoMapper;
using FoodTruckNation.Core.Domain;

namespace FoodTruckNationApi.Locations.Schedules
{

    /// <summary>
    /// API Endpoints related to the schedules of food trucks at a given location
    /// </summary>
    /// <remarks>
    /// Creates a LocationSchedulesController, the controller responsible for returning schedules
    /// (appointments) for a specific location
    /// </remarks>
    /// <param name="logger"></param>
    /// <param name="mapper"></param>
    /// <param name="scheduleService"></param>
    /// <param name="dateTimeProvider"></param>
    [Produces("application/json")]
    [Route("api/Locations/{locationId}/Schedules")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class LocationSchedulesController(ILogger<LocationSchedulesController> logger, IMapper mapper,
        IScheduleService scheduleService, IDateTimeProvider dateTimeProvider) : ApiControllerBase(logger, mapper)
    {
        private readonly IDateTimeProvider _dateTimeProvider = dateTimeProvider;
        private readonly IScheduleService _scheduleService = scheduleService;

        #region Route Name Constants

        internal const string GET_ALL_SCHEDULES_FOR_LOCATION = "GetAllSchedulesForLocation";

        #endregion

        /// <summary>
        /// Gets all of the food trucks scheduled at a location for a given date range
        /// </summary>
        /// <remarks>
        /// If no date range data is provided, then this endpoint will use a date range of the next seven days
        /// </remarks>
        /// <param name="locationId">The id number of the location</param>
        /// <param name="parameters">An optional date range to get the scheduled food trucks for</param>
        /// <returns></returns>
        [HttpGet(Name=GET_ALL_SCHEDULES_FOR_LOCATION)]
        public IActionResult Get(int locationId, GetLocationSchedulesParameters parameters)
        {
            if (!parameters.StartDate.HasValue)
            {
                parameters.StartDate = _dateTimeProvider.CurrentDateTime.Date;
            }

            if (!parameters.EndDate.HasValue)
            {
                parameters.EndDate = parameters.StartDate.Value.AddDays(7).Date;
            }

            var result = _scheduleService.GetSchedulesForLocation(locationId,
                parameters.StartDate.Value, parameters.EndDate.Value);
            return CreateResponse<List<Schedule>, List<LocationScheduleModel>>(result);
        }

    }
}
