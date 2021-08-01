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
                new Person(){ FirstName = "Deneme", LastName="Soyad", PhoneNumber = 12345},
                new Person(){ FirstName = "Deneme", LastName="Soyad", PhoneNumber = 12345},
                new Person(){ FirstName = "Deneme", LastName="Soyad", PhoneNumber = 12345}
            };

            int secim;
            string yanit;
            do
            {
                Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("*****************************************");
                Console.WriteLine("1 - Yeni numara kaydetmek");
                Console.WriteLine("2 - Varolan numarayı silmek");
                Console.WriteLine("3 - Varolan numarayı güncelleme");
                Console.WriteLine("4 - Rehberi listelemek (A-Z veya Z-A seçimli)");
                Console.WriteLine("5 - Rehberde arama yapmak");

                Console.Write("İşlem:");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        AddPerson();
                        break;
                    case 2:
                        DeletePerson();
                        break;
                    case 3:
                        UpdatePerson();
                        break;
                    case 4:
                        GetPersonList();
                        break;
                    case 5:
                        GetByFirstNameOrPhoneNumber();
                        break;
                }
                Console.Write("Devam etmek isiyor musunuz?(e-h):");
                yanit = Console.ReadLine();
            } while (yanit == "e");

        }

        public static void GetPersonList()
        {
            Console.WriteLine("Rehberi nasıl listelemek istersiniz?");
            Console.WriteLine("1 - A-Z sıralı");
            Console.WriteLine("2 - Z-A sıralı");
            Console.Write("Seçiminiz:");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("*******************************************");
                foreach (var item in personList)
                {
                    Console.WriteLine($"İsim: {item.FirstName}\nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}");
                    Console.WriteLine("-");
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("*******************************************");
                foreach (var item in personList.OrderByDescending(x => x.FirstName))
                {
                    Console.WriteLine($"İsim: {item.FirstName}\nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}");
                    Console.WriteLine("-");
                }
            }
        }

        public static void AddPerson()
        {
            Console.Write("Lütfen isim giriniz:");
            string firstName = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz:");
            string lastName = Console.ReadLine();
            Console.Write("Lütfen telefonu giriniz:");
            int phoneNumber = int.Parse(Console.ReadLine());

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
                Console.Write($"{query.FirstName} {query.LastName} rehberden silinecektir, onaylıyoru musunuz? (e/h)");
                char secim = Convert.ToChar(Console.ReadLine().ToLower());
                if (secim == 'e')
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
                char secim = Convert.ToChar(Console.ReadLine().ToLower());

                if (secim == 'e')
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
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                int i = 1;
                Console.Write("İsim veya soyisim giriniz:");
                string firstNameOrLastName = Console.ReadLine();

                var query = personList.Where(x => x.FirstName == firstNameOrLastName || x.LastName == firstNameOrLastName).ToList();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in query)
                {
                    Console.WriteLine($"İsim: {item.FirstName}");
                    Console.WriteLine($"Soyisim: {item.LastName}");
                    Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}");
                    if (query.Count != i)
                    {
                        Console.WriteLine("-");
                    }
                    i++;
                }
            }
            else if (secim == 2)
            {
                int i = 1;
                Console.Write("Telefon numarası giriniz:");
                int phoneNumber = int.Parse(Console.ReadLine());

                var query = personList.Where(x => x.PhoneNumber == phoneNumber).ToList();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in query)
                {
                    Console.WriteLine($"İsim: {item.FirstName}");
                    Console.WriteLine($"Soyisim: {item.LastName}");
                    Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}");
                    if (query.Count != i)
                    {
                        Console.WriteLine("-");
                    }
                    i++;
                }
            }
        }
    }
}
