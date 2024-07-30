using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Team : IEnumerable<Player>
    {
        public string Name { get; set; }
        private List<Player> _team;

        public Team(string name, List<Player> team)
        {
            Name = name;
            _team = team ?? new List<Player>();
        }

        public Team(string name)
        {
            Name = name;
            _team = new List<Player>();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(Name);
            foreach (var item in _team)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString();
        }

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                _team.Add(player);
            }
        }

        public void RemovePlayer(string name)
        {
            _team.RemoveAll(pl => pl.Name == name);
        }

        public static Team operator +(Team team, Player player)
        {
            team.AddPlayer(player);
            return team;
        }

        public static Team operator -(Team team, string name)
        {
            team.RemovePlayer(name);
            return team;
        }

        public static Team operator -(Team team, Player player)
        {
            team._team.Remove(player);
            return team;
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return _team.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _team.GetEnumerator();
        }

        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < _team.Count)
                {
                    return _team[index];
                }
                else
                {
                    throw new Exception($"Некорректный индекс! {index}");
                }
            }
            set
            {
                if (index >= 0 && index < _team.Count)
                {
                    _team[index] = value;
                }
                else
                {
                    throw new Exception($"Некорректный индекс! {index}");
                }
            }
        }
    }
}
