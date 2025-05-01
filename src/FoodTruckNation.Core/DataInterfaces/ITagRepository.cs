using FoodTruckNation.Core.Domain;
using System;
using System.Collections.Generic;

namespace FoodTruckNation.Core.DataInterfaces
{
    public interface ITagRepository
    {

        IList<Tag> GetAllTags();

        IList<Tag> GetAllTagsInUse();

        Tag GetTagById(int id);

        Tag GetTagByName(string name);

        void SaveTag(Tag tag);



    }
}
