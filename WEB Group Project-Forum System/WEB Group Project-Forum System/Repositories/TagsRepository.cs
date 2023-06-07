using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Repositories.Interfaces;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public class TagsRepository : ITagsRepository
    {
        static int nextId = 1;
        private readonly List<Tag> tags;
        public TagsRepository()
        {
            this.tags = new List<Tag>()
            {
                new Tag {Id = nextId++, Name = "UFO"},
                new Tag {Id = nextId++, Name = "Skinwalker"},
                new Tag {Id = nextId++, Name = "Bigfoot"}
            };
        }
        public Post Create(string name)
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
        public void Print()
        {
            foreach (var item in tags)
            {
                Console.WriteLine($"Id:{item.Id}, Name:{item.Name})");
            }
        }
        
}
}
