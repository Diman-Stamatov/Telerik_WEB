﻿using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Repositories.Interfaces;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        static int NextId = 1;
        public List<User> users;

        public User Create(User user)
        {
            CheckDuplicateUsername(user.Username);
            CheckDuplicateEmail(user.Email);
            user.UserID = NextId++;
            this.users.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            var userToDelete = this.GetById(id);
            this.users.Remove(userToDelete);
            return userToDelete;
        }

        public List<User> FilterBy(UserQueryParameters filterParameters)
        {
            var filteredList = this.users;
            if (!string.IsNullOrEmpty(filterParameters.FirstName))
            {
                filteredList = filteredList.FindAll(user => user.FirstName == filterParameters.FirstName);
            }

            if (!string.IsNullOrEmpty(filterParameters.LastName))
            {
                filteredList = filteredList.FindAll(user => user.LastName == filterParameters.LastName);
            }

            if (!string.IsNullOrEmpty(filterParameters.Username))
            {
                filteredList = filteredList.FindAll(user => user.Username == filterParameters.Username);
            }

            if (filterParameters.Blocked != null)
            {
                filteredList = filteredList.FindAll(user => user.Blocked == filterParameters.Blocked);
            }

            if (!string.IsNullOrEmpty(filterParameters.SortBy))
            {
                if (filterParameters.SortBy.Equals("firstname", StringComparison.InvariantCultureIgnoreCase))
                {
                    filteredList = filteredList.OrderBy(user => user.FirstName).ToList();
                }
                else if (filterParameters.SortBy.Equals("lastname", StringComparison.InvariantCultureIgnoreCase))
                {
                    filteredList = filteredList.OrderBy(user => user.LastName).ToList();
                }
                else if (filterParameters.SortBy.Equals("username", StringComparison.InvariantCultureIgnoreCase))
                {
                    filteredList = filteredList.OrderBy(user => user.Username).ToList();
                }

                if (!string.IsNullOrEmpty(filterParameters.SortOrder) && filterParameters.SortOrder.Equals("desc", StringComparison.InvariantCultureIgnoreCase))
                {
                    filteredList.Reverse();
                }
            }
            return filteredList;
        }

        public List<User> GetAll()
        {
            return this.users;
        }

        public User GetById(int id)
        {
            var foundUser = this.users.FirstOrDefault(user => user.UserID == id);
            return foundUser ?? throw new InvalidOperationException($"No user with the ID number {0} exists on the forum!"); //ToDo Custom Exceptions
        }

        public User GetByUsername(string username)
        {
            var foundUser = this.users.FirstOrDefault(user => user.Username == username);
            return foundUser ?? throw new InvalidOperationException($"No user with the Username \"{0}\" exists on the forum!"); //ToDo Custom Exceptions
        }

        public User Update(int id, User user)
        {
            CheckDuplicateUsername(user.Username);
            CheckDuplicateEmail(user.Email);

            var userToUpdate = this.GetById(id);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;
            userToUpdate.Username = user.Username;
            userToUpdate.Password = user.Password;

            return userToUpdate;
        }

        private void CheckDuplicateUsername(string username)
        {
            var foundUser = this.users.FirstOrDefault(user => user.Username == username);
            if (foundUser != null)
            {
                throw new InvalidOperationException($"The username \"{username}\" is already in use!"); //ToDo Custom Exceptions
            }
        }
        private void CheckDuplicateEmail(string email)
        {
            var foundUser = this.users.FirstOrDefault(user => user.Email == email);
            if (foundUser != null)
            {
                throw new InvalidOperationException($"The email \"{email}\" is already in use!"); //ToDo Custom Exceptions
            }
        }
    }
}
