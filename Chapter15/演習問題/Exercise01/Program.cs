using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();


        }

        private static void Exercise1_2() {
            var books = Library.Books.Where(b => b.Price == Library.Books.Max(c => c.Price));
            foreach(var book in books) {
                Console.WriteLine(book);
            }
            //"タイトル:{0}:{1}円({2}年)",book.Title,book.Price,book.PublishedYear
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach(var years in groups) {
                var yearCount = years.Count();
                Console.WriteLine("{0}年 {1}冊",years.Key,yearCount);
            }
        }

        private static void Exercise1_4() {

            var groups = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id,
                (book, category) => new {
                    Title = book.Title,
                    CategoryName = category.Name,
                    PublishedYear = book.PublishedYear,
                    Price = book.Price
                }).
                OrderByDescending(b => b.PublishedYear).ThenByDescending(p => p.Price);
            foreach(var book in groups) {
                Console.WriteLine("{0}年 {1}円 {2}({3})",book.PublishedYear,book.Price,book.Title,book.CategoryName);
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                (book, category) => category.Name).Distinct();

            foreach(var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {

            var groups = Library.Books.Join(Library.Categories,book => book.CategoryId,category => category.Id,
                (book, category) => new {
                    Category = category.Name,
                    Title = book.Title
                }).GroupBy(b => b.Category).OrderBy(x => x.Key);
            foreach(var group in groups) {
                Console.WriteLine("#{0}", group.Key);
                foreach(var book in group) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id,
                (book, category) => new {
                    Category = category.Name,
                    Title = book.Title,
                    PublishedYear = book.PublishedYear

                }).Where(c => c.Category == "Development").GroupBy(b => b.PublishedYear).OrderBy(x => x.Key);

            foreach(var group in groups) {
                Console.WriteLine("#{0}年", group.Key);
                foreach(var book in group) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            
        }
    }
}
