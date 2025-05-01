using System;

namespace FoodTruckNation.Core.Commands
{
    public class UpdateFoodTruckCommand
    {
        public int FoodTruckId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public DateTime LastModifiedDate { get; set; }

    }

}
