﻿using ForumSystemTeamFour.Models;
using ForumSystemTeamFour.Models.QueryParameters;
using System.Collections.Generic;

namespace ForumSystemTeamFour.Services.Interfaces
{
    public interface IUserServices
    {
        List<User> GetAll();
        List<User> FilterBy(UserQueryParameters filterParameters);        
        User GetByUsername(string name);        
        User Create(User user);
        User Update(string username, UserUpdateData updateData);
        User Delete(string username);
        User Block(string username);
        User Unblock(string username);
        User PromoteToAdmin(string username);
        User DemoteFromAdmin(string username);
    }
}
