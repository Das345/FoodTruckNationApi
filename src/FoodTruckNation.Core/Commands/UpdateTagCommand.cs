using System;

namespace FoodTruckNation.Core.Commands
{
    public class UpdateTagCommand
    {
        public int TagId { get; set; }

        public string TagText { get; set; }

    }
}
