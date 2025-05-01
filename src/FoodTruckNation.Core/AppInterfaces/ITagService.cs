using FoodTruckNation.Core.Commands;
using FoodTruckNation.Core.Domain;
using DavidBerry.Framework.Functional;
using System.Collections.Generic;

namespace FoodTruckNation.Core.AppInterfaces
{
    public interface ITagService
    {

        Result<IList<Tag>> GetAllTags();

        Result<IList<Tag>> GetTagsInUse();

        Result<Tag> GetTagById(int tagId);

        Result<Tag> GetTagByName(string tag);

        Result<Tag> CreateNewTag(string tag);

        Result<Tag> UpdateTag(UpdateTagCommand updateTagCommand);


    }
}
