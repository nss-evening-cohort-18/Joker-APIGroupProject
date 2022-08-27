using Joker_APIGroupProject.Models;
using Joker_APIGroupProject.Interface;


namespace Joker_APIGroupProject.Repositories
{
    public class SpyRepository : ISpy
    {
        private static List<string> _allSkills = new();

        private static List<Spy> _spiesBySkill = new();

        private static List<Spy> _spies = new()

        {
          
            new Spy()
            {
                Id = 1,
                UserName = "MojoMan",
                Skills = new() {"Womanizer", "Time-Travel", "Mystery"},
                Friends = new() { },
                Enemies = new() { "077" },
                OriginStory = "Daddy Issues",
                Services = new() {"Dancing", "Rescue"}
            },
            new Spy()
            {
                Id = 2,
                UserName = "077",
                Skills = new() { "Womanizer", "Poker", "Killing" },
                Friends = new() { "SilverBosman" },
                Enemies = new() { "Sam Fisher" },
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
            },

            new Spy()
            {
                Id = 4,
                UserName = "Sam Fisher",
                Skills = new() {"Bongos", "Water Color", "Espionoge", "Master of Disguise"},
                Friends = new() { },
                Enemies = new() { "077" },
                OriginStory = "Born in the Dark",
                Services = new() {"Assasination", "Overthrow a Government", "Bounce Houses"}
            }
        };

        public List<Spy> GetAll()
        {
            return _spies;
        }

        public List<string> GetEnemiesById(int id)
        {
            return _spies.FirstOrDefault(p => p.Id == id).Enemies;

        }
        public List<string> GetFriendsById(int id)
        {
            return _spies.FirstOrDefault(p => p.Id == id).Friends;

        }
       

        public Spy GetById(int id)
        {
            return _spies.FirstOrDefault(p => p.Id == id);
        }

        public bool Create(Spy value)
        {
            _spies.Add(value);
            return true;
        }

        public List<Spy> GetSpysBySkill(string skill)
        {

            foreach (Spy spy in _spies)
            {
                foreach (var s in spy.Skills)
                    if (s == skill)
                    {
                        _spiesBySkill.Add(spy);
                    }
            }
            return _spiesBySkill;
        }

        public List<string> GetAllSkills()
        {
           foreach (var s in _spies)
            {
                foreach (var s2 in s.Skills)
                {
                    _allSkills.Add(s2);
                }
            }
            return _allSkills;
        }
    }
}
