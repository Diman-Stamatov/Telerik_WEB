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
        public Tag Create(string name)
        {
            var foundTag = GetByName(name);
            if (foundTag == null)
            {
                var newTag = new Tag
                {
                    Id = nextId++,
                    Name = name
                };
                this.tags.Add(newTag);
                return newTag;

            }            
            throw new InvalidOperationException($"The tag \"{name}\" already exists!");
        }
        public Tag GetByName(string name)
        {
            var foundTag = tags.FirstOrDefault(tag => tag.Name == name);
            return foundTag;
        }

        public Tag Delete(string name)
        {
            var foundTag = GetByName(name);
            if (foundTag == null)
            {
                throw new InvalidOperationException($"The tag \"{name}\" does not exist!");
            }

            this.tags.Remove(foundTag);
            return foundTag;
        }
                

        public List<Tag> GetAll()
        {
            if (this.tags.Count ==0)
            {
                throw new InvalidOperationException("No tags have been created yet!");
            }
            return this.tags;
        }

        public Tag GetById(int id)
        {
            var foundTag = this.tags.FirstOrDefault(tag=>tag.Id == id);
            return foundTag ?? throw new InvalidOperationException($"No tag with the ID {id} has been created yet!");
        }

        public Tag Update(int id, string name)
        {
            var foundTag = GetById(id);
            foundTag.Name = name;
            return foundTag;
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
