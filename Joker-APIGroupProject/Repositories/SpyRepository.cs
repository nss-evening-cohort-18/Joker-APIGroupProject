using Joker_APIGroupProject.Models;
using Joker_APIGroupProject.Interface;


namespace Joker_APIGroupProject.Repositories
{
    public class SpyRepository : ISpy
    {
        private static List<Spy> _spies = new()
        {
            new Spy()
            {

            }
        }
    }
}
