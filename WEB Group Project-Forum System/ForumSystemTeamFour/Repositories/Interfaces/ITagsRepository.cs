﻿using ForumSystemTeamFour.Models.QueryParameters;
using ForumSystemTeamFour.Models;
using System.Collections.Generic;

namespace ForumSystemTeamFour.Repositories.Interfaces
{
    public interface ITagsRepository
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        Tag GetByName(string name);
        Tag Create(string name);
        Tag Delete(int id);
    }
}
