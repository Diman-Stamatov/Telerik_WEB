using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Repositories;
using WEB_Group_Project_Forum_System.Services.Interfaces;

namespace WEB_Group_Project_Forum_System.Services
{
    public class TagService : ITagService
    {
        private readonly TagsRepository tagsRepository;
        public TagService(TagsRepository tagsRepository)
        {
            this.tagsRepository = tagsRepository;
        }

        public Tag Create(string name)
        {
            return this.tagsRepository.Create(name);
           
        }

        public Tag Delete(string name)
        {            
            return this.tagsRepository.Delete(name); 
        }

        public List<Tag> GetAll()
        {
            return this.tagsRepository.GetAll();
        }

        public Tag GetById(int id)
        {
            return this.tagsRepository.GetById(id);
        }

        public Tag Update(int id, string name)
        {
            return tagsRepository.Update(id, name);
        }
    }
}
