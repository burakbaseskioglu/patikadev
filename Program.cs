using System;
using System.Collections.Generic;
using proje_2.Entities;
using proje_2.Enums;
using System.Linq;

namespace proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoiceMenu();
        }

        static void ChoiceMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("1 - Board Listelemek");
            Console.WriteLine("2 - Board'a Kart Eklemek");
            Console.WriteLine("3 - Board'dan Kart Silmek");
            Console.WriteLine("4 - Kart Taşımak");
            Console.WriteLine("5 - Çıkış");

            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());
            StartPage(choice);
        }

        static void StartPage(int choice)
        {
            switch (choice)
            {
                case 1:
                    GetListBoard();
                    break;
                case 2:
                    AddCard();
                    break;
                case 3:
                    DeleteCard();
                    break;
                case 5:
                    Console.WriteLine("Çıkış yapıldı.");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir seçim yapınız!");
                    ChoiceMenu();
                    break;
            }
        }

        static void AddCard()
        {
            Console.Write("Başlık giriniz :");
            string title = Console.ReadLine();
            Console.Write("İçerik giriniz :");
            string content = Console.ReadLine();
            Console.Write("Büyüklük seçiniz :");
            string sizes = Console.ReadLine();
            Sizes sizes2 = 0;
            switch (sizes)
            {
                case "1":
                    sizes2 = proje_2.Enums.Sizes.XS;
                    break;
                case "2":
                    sizes2 = proje_2.Enums.Sizes.S;
                    break;
                case "3":
                    sizes2 = proje_2.Enums.Sizes.M;
                    break;
                case "4":
                    sizes2 = proje_2.Enums.Sizes.L;
                    break;
                case "5":
                    sizes2 = proje_2.Enums.Sizes.XL;
                    break;
            }
            Console.Write("Takım üyesi Id giriniz :");
            int id = int.Parse(Console.ReadLine());
            var query = TeamMemberDataSource.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (query != null)
            {
                Card card = new Card
                {
                    Title = title,
                    Content = content,
                    Sizes = sizes2,
                    TeamMemberId = id
                };
                Board.ToDo.Add(card);
            }
            else
            {
                Console.WriteLine("Tanımlı bir id girmediniz. İşlem iptal edildi!");
            }
        }

        static void AddWhiteSpace(int itemCount)
        {
            int i = 1;
            if (i != itemCount)
            {
                Console.WriteLine(" ");
            }
            i++;
        }

        static void GetListBoard()
        {
            Console.WriteLine("ToDo Line");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            foreach (var item in Board.ToDo)
            {
                Console.WriteLine($"Başlık : {item.Title}\nİçerik : {item.Content}\nAtanan Kişi : {item.TeamMemberId}\nBüyüklük : {item.Sizes}");
                AddWhiteSpace(Board.ToDo.Count);
            }

            Console.WriteLine();
            Console.WriteLine("In Progress Line");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            foreach (var item in Board.InProgress)
            {
                Console.WriteLine($"Başlık : {item.Title}\nİçerik : {item.Content}\nAtanan Kişi : {item.TeamMemberId}\nBüyüklük : {item.Sizes}");
                AddWhiteSpace(Board.InProgress.Count);
            }

            Console.WriteLine();
            Console.WriteLine("Done Line");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            foreach (var item in Board.Done)
            {
                Console.WriteLine($"Başlık : {item.Title}\nİçerik : {item.Content}\nAtanan Kişi : {item.TeamMemberId}\nBüyüklük : {item.Sizes}");
                AddWhiteSpace(Board.Done.Count);
            }
        }

        static void DeleteCard()
        {
            Console.WriteLine("Silmek istediğiniz kartı seçiniz.");
            Console.Write("Lütfen kart başlığı yazınız:");
            string cardTitle = Console.ReadLine();

            var toDoQuery = Board.ToDo.Where(x => x.Title == cardTitle).ToList();
            var inProgressQuery = Board.InProgress.Where(x => x.Title == cardTitle).ToList();
            var doneQuery = Board.Done.Where(x => x.Title == cardTitle).ToList();

            if (toDoQuery.Count > 0 || inProgressQuery.Count > 0 || doneQuery.Count > 0)
            {
                foreach (var item in toDoQuery)
                {
                    Board.ToDo.Remove(item);
                }
                foreach (var item in inProgressQuery)
                {
                    Board.InProgress.Remove(item);
                }
                foreach (var item in doneQuery)
                {
                    Board.Done.Remove(item);
                }
            }
            else
            {
                Console.WriteLine("Kayıtlara uygun veri bulunamadı.");
                Console.WriteLine("* İşlemi sonlandırmak için (1)");
                Console.WriteLine("* Yeniden denemek için (2)");
                Console.Write("Seçiminiz:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    ChoiceMenu();
                }
                else if (choice == 2)
                {
                    DeleteCard();
                }
            }
        }
        static int MoveCardChoiceMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
            Console.WriteLine("1 - ToDo\n2 - In Progress\n3 - Done");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void ShowFindCard(Card card)
        {
            Console.WriteLine("Bulunan Kart Bilgileri");
            Console.WriteLine("**********************");
            Console.WriteLine($"{card.Title}\n{card.Content}\n{card.Sizes}\n{card.TeamMemberId}");
        }

        static void MoveCard()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz kartı seçiniz.");
            Console.Write("Kart başlığı yazınız:");
            string cardTitle = Console.ReadLine();

            var toDoQuery = Board.ToDo.FirstOrDefault(x => x.Title == cardTitle);
            var doneQuery = Board.Done.FirstOrDefault(x => x.Title == cardTitle);
            var inProgressQuery = Board.InProgress.FirstOrDefault(x => x.Title == cardTitle);

            if (toDoQuery != null)
            {
                ShowFindCard(toDoQuery);
                int choice = MoveCardChoiceMenu();
                if (choice == 1)
                {
                    Console.WriteLine("Kart zaten ToDo Line'da mevcut!");
                }
                else if (choice == 2)
                {
                    Board.InProgress.Add(toDoQuery);
                    Board.ToDo.Remove(toDoQuery);
                }
                else if (choice == 3)
                {
                    Board.Done.Add(toDoQuery);
                    Board.ToDo.Remove(toDoQuery);
                }
                else
                {
                    Console.WriteLine("Lütfen 1 ile 3 arasında bir seçim yapınız!");
                }
            }
            else if (inProgressQuery != null)
            {
                ShowFindCard(inProgressQuery);
                int choice = MoveCardChoiceMenu();
                if (choice == 1)
                {
                    Board.ToDo.Add(inProgressQuery);
                    Board.InProgress.Remove(inProgressQuery);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Kart zaten In Progress Line'da mevcut!");
                }
                else if (choice == 3)
                {
                    Board.Done.Add(inProgressQuery);
                    Board.InProgress.Remove(inProgressQuery);
                }
                else
                {
                    Console.WriteLine("Lütfen 1 ile 3 arasında bir seçim yapınız!");
                }
            }
            else if (doneQuery != null)
            {
                ShowFindCard(doneQuery);
                int choice = MoveCardChoiceMenu();
                if (choice == 1)
                {
                    Board.ToDo.Add(doneQuery);
                    Board.Done.Remove(doneQuery);
                }
                else if (choice == 2)
                {
                    Board.InProgress.Add(doneQuery);
                    Board.Done.Remove(doneQuery);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Kart zaten Done Line'da mevcut!");
                }
                else
                {
                    Console.WriteLine("Lütfen 1 ile 3 arasında bir seçim yapınız!");
                }
            }
            else
            {
                Console.WriteLine("Kayıtlara uygun veri bulunamadı.");
                Console.WriteLine("* İşlemi sonlandırmak için (1)");
                Console.WriteLine("* Yeniden denemek için (2)");
                Console.Write("Seçiminiz:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    ChoiceMenu();
                }
                else if (choice == 2)
                {
                    MoveCard();
                }
            }
        }
    }
}
