using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System.Repositories.Interfaces
{
    public interface IEmailsRepository
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        Tag GetByName(string name);
        Tag Create(string name);
        Tag Delete(string name);
    }
}
