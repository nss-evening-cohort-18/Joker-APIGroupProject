using Joker_APIGroupProject.Models;


namespace Joker_APIGroupProject.Interface
{
    public interface ISpy
    {
        Spy GetById(int id);

        List <string> GetEnemiesById(int id);

        List<string> GetFriendsById(int id);

        List<Spy> GetSpysBySkill(string skill);

        List<Spy> GetAll();

        public bool Create(Spy value);
    
    }
}
