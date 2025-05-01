using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DavidBerry.Framework.ApiUtil.Controllers;
using Microsoft.Extensions.Logging;
using AutoMapper;
using FoodTruckNation.Core.AppInterfaces;
using DavidBerry.Framework.TimeAndDate;
using FoodTruckNation.Core.Domain;
using FoodTruckNation.Core.Commands;
using DavidBerry.Framework.ApiUtil.Models;

namespace FoodTruckNationApi.FoodTrucks.Schedules
{
    /// <summary>
    /// Controller for managing schedules of food trucks.
    /// </summary>
    [Produces("application/json")]
    [Route("api/FoodTrucks/{foodTruckId}/Schedules")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class FoodTruckSchedulesController : ApiControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodTruckSchedulesController"/> class.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        /// <param name="scheduleService">The schedule service for managing food truck schedules.</param>
        /// <param name="dateTimeProvider">The date-time provider for current date and time.</param>
        public FoodTruckSchedulesController(ILogger<FoodTruckSchedulesController> logger, IMapper mapper,
            IScheduleService scheduleService, IDateTimeProvider dateTimeProvider)
            : base(logger, mapper)
        {
            _dateTimeProvider = dateTimeProvider;
            _scheduleService = scheduleService;
        }

        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IScheduleService _scheduleService;

        #region Route Name Constants

        /// <summary>
        /// Route name for getting all schedules of a food truck.
        /// </summary>
        internal const string GET_FOOD_TRUCK_SCHEDULE = "GetFoodTruckSchedule";

        /// <summary>
        /// Route name for getting a single schedule of a food truck.
        /// </summary>
        internal const string GET_SINGLE_FOOD_TRUCK_SCHEDULE = "GetFoodTruckScheduleById";

        #endregion

        // The rest of the methods already have XML comments and do not need changes.
    }
}
