using System.Collections.Generic;

namespace proje_2.Entities
{
    public class TeamMember
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }

    public static class TeamMemberDataSource
    {
        static TeamMemberDataSource()
        {
            TeamMembers = AddTeamMembers();
        }

        public static List<TeamMember> TeamMembers;

        private static List<TeamMember> AddTeamMembers()
        {
            return new List<TeamMember>()
            {
                new TeamMember { Id = 1, Name = "Ali Aydın" },
                new TeamMember { Id = 2, Name = "Fatih Yılmaz" },
                new TeamMember { Id = 3, Name = "Ayşe Uğur" },
                new TeamMember { Id = 4, Name = "Yılmaz Can" },
                new TeamMember { Id = 5, Name = "Aslı Yıldız" }
            };
        }
    }
}