using FoodTruckNation.Core.Domain;
using FoodTruckNation.Core.DataInterfaces;
using DavidBerry.Framework.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FoodTruckNation.Data.EF.Repositories
{
    public class LocationRepository(FoodTruckContext context) : ILocationRepository
    {
        private readonly FoodTruckContext _foodTruckContext = context;




        public Location GetLocation(int locationId)
        {
            var location = _foodTruckContext.Locations
                .Where(l => l.LocationId == locationId)
                .AsNoTracking()
                .SingleOrDefault();

            return location;
        }

        public List<Location> GetLocations()
        {
            var locations = _foodTruckContext.Locations
                .AsNoTracking()
                .ToList();

            return locations;
        }



        public void Save(Location location)
        {
            _foodTruckContext.ChangeTracker.TrackGraph(location, EfExtensions.ConvertStateOfNode);
        }


        public void Delete(Location location)
        {
            _foodTruckContext.Remove(location);
        }

    }
}
