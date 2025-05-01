using System;

namespace FoodTruckNation.Core.Commands
{
    public class CreateReviewCommand
    {

        public int FoodTruckId { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }

    }
}
