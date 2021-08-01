using System;
using System.Collections.Generic;
using System.Linq;
using proje_1.Entities;

namespace proje_1
{
    class Program
    {
        static List<Person> personList;
        static void Main(string[] args)
        {
            personList = new List<Person>()
            {
                new Person(){ FirstName = "Ali", LastName="Aydın", PhoneNumber = "05301112233"},
                new Person(){ FirstName = "Fatih", LastName="Yılmaz", PhoneNumber = "05342221133"},
                new Person(){ FirstName = "Deniz", LastName="Öztürk", PhoneNumber = "05303332211"},
                new Person(){ FirstName = "Ayşe", LastName="Demir", PhoneNumber = "05464442233"},
                new Person(){ FirstName = "Aslı", LastName="Yiğit", PhoneNumber = "05356662232"}
            };

            StartPage();
        }

        public static void StartPage()
        {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("1 - Yeni numara kaydetmek");
            Console.WriteLine("2 - Varolan numarayı silmek");
            Console.WriteLine("3 - Varolan numarayı güncelleme");
            Console.WriteLine("4 - Rehberi listelemek (A-Z veya Z-A seçimli)");
            Console.WriteLine("5 - Rehberde arama yapmak");
            Console.WriteLine("6 - Çıkış yapmak");

            Console.Write("İşlem:");
            int choice = int.Parse(Console.ReadLine());
            MainPage(choice);
        }

        public static void MainPage(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddPerson();
                    StartPage();
                    break;
                case 2:
                    DeletePerson();
                    StartPage();
                    break;
                case 3:
                    UpdatePerson();
                    StartPage();
                    break;
                case 4:
                    PersonList();
                    StartPage();
                    break;
                case 5:
                    GetByFirstNameOrPhoneNumber();
                    StartPage();
                    break;
                case 6:
                    Console.WriteLine("Çıkış yapıldı...");
                    break;
            }
        }

        public static void GetPersonList(List<Person> list)
        {
            int i = 1;
            foreach (var item in list)
            {
                Console.WriteLine($"İsim: {item.FirstName}\nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}");
                if (personList.Count != i)
                {
                    Console.WriteLine();
                }
                i++;
            }
        }

        public static void PersonList()
        {
            Console.WriteLine("Rehberi nasıl listelemek istersiniz?");
            Console.WriteLine("1 - A-Z sıralı");
            Console.WriteLine("2 - Z-A sıralı");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("*******************************************");
                GetPersonList(personList.OrderBy(x => x.FirstName).ToList());
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("*******************************************");
                GetPersonList(personList.OrderByDescending(x => x.FirstName).ToList());
            }
        }

        public static void AddPerson()
        {
            Console.Write("Lütfen isim giriniz:");
            string firstName = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz:");
            string lastName = Console.ReadLine();
            Console.Write("Lütfen telefonu giriniz:");
            string phoneNumber = Console.ReadLine();

            personList.Add(new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            });
        }

        public static void DeletePerson()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını veya soyadını giriniz:");
            string firstNameOrLastName = Console.ReadLine();

            var query = personList.FirstOrDefault(x => x.FirstName == firstNameOrLastName || x.LastName == firstNameOrLastName);
            if (query != null)
            {
                Console.Write($"{query.FirstName} {query.LastName} rehberden silinecektir, onaylıyor musunuz? (e/h):");
                char choice = Convert.ToChar(Console.ReadLine().ToLower());
                if (choice == 'e')
                {
                    personList.Remove(query);
                    Console.WriteLine($"{query.FirstName} {query.LastName} isimli kişi rehberden başarı ile silindi");
                }
                else
                {
                    Console.WriteLine("Silme işleminden vazgeçildi.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri bulunamadı. Ne yapmak istiyorsunuz?");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                Console.Write("Seçiminiz:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    StartPage();
                }
                else if (choice == 2)
                {
                    DeletePerson();
                }
            }
        }

        public static void UpdatePerson()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını veya soyadını giriniz:");
            string firstNameOrLastName = Console.ReadLine();

            var query = personList.FirstOrDefault(x => x.FirstName == firstNameOrLastName || x.LastName == firstNameOrLastName);
            if (query != null)
            {
                Console.Write("Seçtiğiniz kişi güncellenecektir, onaylıyor musunuz? (e/h)");
                char choice = Convert.ToChar(Console.ReadLine().ToLower());

                if (choice == 'e')
                {
                    personList.Remove(query);
                    AddPerson();
                    Console.WriteLine("Güncelleme işlemi başarı ile tamamlandı.");
                }
                else
                {
                    Console.WriteLine("Güncelleme işleminden vazgeçildi.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri bulunamadı. Ne yapmak istiyorsunuz?");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                Console.WriteLine("Seçiminiz:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    StartPage();
                }
                else if (choice == 2)
                {
                    UpdatePerson();
                }
            }
        }

        public static void GetByFirstNameOrPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisme göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("İsim veya soyisim giriniz:");
                string firstNameOrLastName = Console.ReadLine();

                var query = personList.Where(x => x.FirstName == firstNameOrLastName || x.LastName == firstNameOrLastName).ToList();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                GetPersonList(query);
            }
            else if (choice == 2)
            {
                Console.Write("Telefon numarası giriniz:");
                string phoneNumber = Console.ReadLine();

                var query = personList.Where(x => x.PhoneNumber == phoneNumber).ToList();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                GetPersonList(query);
            }
        }
    }
}
