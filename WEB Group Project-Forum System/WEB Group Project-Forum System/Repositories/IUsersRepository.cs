﻿using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public interface IUsersRepository
    {
        List<Post> GetAll();
        List<Post> FilterBy(UserQueryParameters filterParameters);
        Post GetById(int id);
        Post Create(UserDto userDto);
        Post Update(int id, UserDto userDto);
        Post Delete(int id);
    }
}