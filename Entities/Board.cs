using System;
using System.Collections.Generic;

namespace proje_2.Entities
{
    public static class Board
    {
        static Board()
        {
            ToDo = AddToDo();
            InProgress = AddInProgress();
            Done = AddDone();
        }

        public static List<Card> ToDo;
        public static List<Card> InProgress;
        public static List<Card> Done;

        private static List<Card> AddToDo()
        {
            return new List<Card>()
            {
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.XL, TeamMemberId = 1 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.S, TeamMemberId = 3 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.M, TeamMemberId = 4 }
            };
        }

        private static List<Card> AddInProgress()
        {
            return new List<Card>()
            {
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.S, TeamMemberId = 5 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.XL, TeamMemberId = 2 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.XL, TeamMemberId = 3 }
            };
        }

        private static List<Card> AddDone()
        {
            return new List<Card>()
            {
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.M, TeamMemberId = 4 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.XL, TeamMemberId = 4 },
                new Card { Title = "", Content = "", Sizes = Enums.Sizes.L, TeamMemberId = 5 }
            };
        }
    }
}