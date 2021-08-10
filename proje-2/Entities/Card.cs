using proje_2.Enums;

namespace proje_2.Entities
{
    public class Card
    {
        private string title;
        private string content;
        private int teamMemberId;
        private Sizes sizes;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int TeamMemberId { get => teamMemberId; set => teamMemberId = value; }
        public Sizes Sizes { get => sizes; set => sizes = value; }
    }
}