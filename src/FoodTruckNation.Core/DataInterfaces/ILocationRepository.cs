using FoodTruckNation.Core.Domain;
using System.Collections.Generic;

namespace FoodTruckNation.Core.DataInterfaces
{
    public interface ILocationRepository
    {


        Location GetLocation(int locationId);


        List<Location> GetLocations();


        void Save(Location location);


        void Delete(Location location);


    }
}
