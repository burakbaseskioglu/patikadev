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
    }
}
