using ForumSystemTeamFour.Models;
using System.Collections.Generic;

namespace ForumSystemTeamFour.Services.Interfaces
{
    public interface ITagServices
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        Tag GetByName(string name);
        Tag Create(string name);
        Tag Delete(int id);
    }
}
