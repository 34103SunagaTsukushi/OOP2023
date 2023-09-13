using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //Console.Write("データを挿入しました。続けるにはEnterキーを押してください。");

            DisplayAllBooks();
            Console.ReadLine();
            Console.WriteLine();



        }
        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();//データベースを更新
                Console.WriteLine($"{book1.Id}{book2.Id}");
            }
        }

        static IEnumerable<Book> GetBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books
                    .Where(book => book.Author.Name.StartsWith("夏目"))
                    .ToList();


            }
        }
        //List13-8

        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();//コンソールの画面をすぐに消さないためにキー入力待ちにする

        }
    }
}
