using System.Collections.Generic;

namespace proje_2.Entities
{
    public class CardViewModel
    {
        public CardViewModel()
        {
            ToDo = new List<Card>();
            InProgress = new List<Card>();
            Done = new List<Card>();
        }
        public List<Card> ToDo { get; set; }
        public List<Card> InProgress { get; set; }
        public List<Card> Done { get; set; }
    }
}