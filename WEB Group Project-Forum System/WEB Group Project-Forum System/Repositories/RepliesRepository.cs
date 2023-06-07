using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Repositories.Interfaces;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public class RepliesRepository : IRepliesRepository
    {
        private readonly List<Reply> replies;
        
        public Post Create(PostDto postDto)
        {
            throw new NotImplementedException();
        }

        public Post Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> FilterBy(ReplyQueryParameters filterParameters)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Post Update(int id, PostDto postDto)
        {
            throw new NotImplementedException();
        }
    }
}
