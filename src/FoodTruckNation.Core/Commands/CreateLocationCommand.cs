using System;

namespace FoodTruckNation.Core.Commands
{
    public class CreateLocationCommand
    {

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }


    }
}
