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
                Id = 1,
                UserName = "MojoMan",
                Skills = new() {"Womanizer", "Time-Travel", "Mystery"},
                Friends = new() { },
                Enemies = new() { },
                OriginStory = "Daddy Issues",
                Services = new() {"Dancing", "Rescue"}
            },
            new Spy()
            {
                Id = 2,
                UserName = "077",
                Skills = new() { "Womanizer", "Poker", "Killing" },
                Friends = new() { "SilverBosman" },
                Enemies = new() { },
                OriginStory = "Orphan",
                Services = new() { "Assassinations", "Bomb Stopping" }
            },
            new Spy()
            {
                Id = 3,
                UserName = "SilverBowsman",
                Skills = new() { "Cocktails", "Poker", "Driving" },
                Friends = new() { "077" },
                Enemies = new() { "MojoMan" },
                OriginStory = "Mommy Issues",
                Services = new() { "Assassinations", "Cover-Ups" }
            }
        }
public List<Spy> GetAll()
        {
            throw new NotImplementedException();
        }

        public Spy GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
