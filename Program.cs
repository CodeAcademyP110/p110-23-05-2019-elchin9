using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Axundov");
            Books code = new Books("C# Book");
            Books code2 = new Books("Javascript Book");
            code2.ISBN = "01";
            Rooms room = new Rooms();
            Rooms room2 = new Rooms();
            code.Price = 150;
            Journal jou = new Journal("The Times");
            Journal jou1 = new Journal("The Times");
            Journal jou2 = new Journal("The Times");
            library.AddBooks(code);
            library.AddBooks(code2);

            
        }
    }
    public class Library
    {
        public string Name;
        public Books[] books;
        private int bookCounter;
        public Journal[] journal;
        private int jouCounter;
        public Encyclopedia[] encyclopedia;
        private int enCounter;
        public Rooms[] rooms;


        public Library(string name)
        {
            Name = name;
        }

        public void AddBooks(Books book)
        {
            books[bookCounter++] = book;
        }
        public void AddJournal(Journal jou)
        {
            journal[jouCounter++] = jou;
        }
        public void AddEncyclopedia(Encyclopedia enc)
        {
            encyclopedia[enCounter++] = enc;
        }

        public void ReserveRooms(Rooms room, DateTime day)
        {

            if (room.State == "empty" & room.Day != day & day >= DateTime.Today)
            {
                room.State = "reserved";
                Console.WriteLine($"Sizin reserviniz {day} tarixine ugurla edilmisdir.");
            }
            else
            {
                Console.WriteLine($"Istenilen gunde rezerv mumkun deyildir. Xahis edirik basqa gun secin.");
            }
            room.Day = day;
        }

    }
    public class Books
    {
        public string Name;
        public string ISBN;
        public string Genre;
        public string Author;
        public int Price;
        public int BookNumber;
        public static int ISBNCounter = 1;

        public Books(string name)
        {
            Name = name;

            string id = ISBNCounter < 10 ? "0" + ISBNCounter : ISBNCounter.ToString();
            ISBN = id;
            ISBNCounter++;
        }

        public bool HasDiscount()
        {
            if (Price > 100)
            {
                Console.WriteLine("Bu kitabda endirim movcuddur.");
                return true;
            }
            Console.WriteLine("Bu kitabda endirim yoxdur.");
            return false;
        }

        public int DiscountPercent(int discountPrice)
        {
            if (HasDiscount())
            {
                int total = Price * discountPrice / 100;
                Console.WriteLine($"Sizin endiriminiz {total} AZN olacaq.");
                return total;
            }

            Console.WriteLine("Size endirim tetbiq edilmir.");
            return Price;
        }

    }
    public class Journal
    {
        public string Name;
        public string ISBN;
        public string Genre;
        public string Author;
        public int Price;
        public int JournalNumber;
        public static int ISBNCounter = 1;

        public Journal(string name)
        {
            Name = name;

            string id = ISBNCounter < 10 ? "0" + ISBNCounter : ISBNCounter.ToString();
            ISBN = id;
            ISBNCounter++;
        }
        public bool HasDiscount()
        {
            if (Price > 100)
            {
                Console.WriteLine("Bu jurnalda endirim movcuddur.");
                return true;
            }
            Console.WriteLine("Bu jurnalda endirim yoxdur.");
            return false;
        }

        public int DiscountPercent(int discountPrice)
        {
            if (HasDiscount())
            {
                int total = Price * discountPrice / 100;
                Console.WriteLine($"Sizin endiriminiz {total} AZN olacaq.");
                return total;
            }

            Console.WriteLine("Size endirim tetbiq edilmir.");
            return Price;
        }
    }
    public class Encyclopedia
    {
        public string Name;
        public string ISBN;
        public string Genre;
        public string Author;
        public int Price;
        public int EncyclopediaNumber;
        public static int ISBNCounter = 1;

        public Encyclopedia(string name)
        {
            Name = name;

            string id = ISBNCounter < 10 ? "0" + ISBNCounter : ISBNCounter.ToString();
            ISBN = id;
            ISBNCounter++;
        }
        public bool HasDiscount()
        {
            if (Price > 100)
            {
                Console.WriteLine("Bu ensiklopediyada endirim movcuddur.");
                return true;
            }
            Console.WriteLine("Bu ensiklopediyada endirim yoxdur.");
            return false;
        }

        public int DiscountPercent(int discountPrice)
        {
            if (HasDiscount())
            {
                int total = Price * discountPrice / 100;
                Console.WriteLine($"Sizin endiriminiz {total} AZN olacaq.");
                return total;
            }

            Console.WriteLine("Size endirim tetbiq edilmir.");
            return Price;
        }

    }
    public class Rooms
    {
        public string Name;
        public int RoomNumber;
        public static int RoomCounter = 1;
        public string RoomID;
        public string State;
        public DateTime Day;

        public Rooms()
        {
            string id = RoomCounter < 100 ? "00" + RoomCounter : RoomCounter.ToString();
            RoomID = id;
            RoomCounter++;
            State = "empty";
        }
    }

}
