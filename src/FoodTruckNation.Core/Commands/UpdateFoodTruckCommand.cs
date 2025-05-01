using System;

namespace FoodTruckNation.Core.Commands
{
    public class UpdateFoodTruckCommand
    {
        public int FoodTruckId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public String Website { get; set; }

        public DateTime LastModifiedDate { get; set; }

    }

}
