using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoGenerator_Test
{
    public class BookTest
    {
        [Test]
        public void Caso01() {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result=bookStore.GetTotal();

            Assert.AreEqual(55.0m, result);
        }

        [Test]
        public void Caso02()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            book.Name = "It";
            book.Price = 65.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(120.0m, result);
        }

        [Test]
        public void Caso03()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(104.5m, result);
        }

        [Test]
        public void Caso04()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "It";
            book.Price = 10.0m;
            bookStore.AddToCart(book);

            book.Name = "It";
            book.Price = 10.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(19m, result);
        }

        [Test]
        public void Caso05()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "La biblia de los Caídas";
            book.Price = 10.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(10.0m, result);
        }

        [Test]
        public void Caso06()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "La biblia de los Caídas";
            book.Price = 15.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(15.0m, result);
        }

        [Test]
        public void Caso07()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter II";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            book.Name = "Harry Potter II";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(104.5m, result);
        }

        [Test]
        public void Caso08()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "QUIMICA";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(55.5m, result);
        }

        [Test]
        public void Caso09()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(104.5m, result);
        }

        [Test]
        public void Caso10()
        {
            var book = new Book();
            var bookStore = new BookStore();
            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            book.Name = "Harry Potter";
            book.Price = 55.0m;
            bookStore.AddToCart(book);

            var result = bookStore.GetTotal();

            Assert.AreEqual(104.5m, result);
        }

    }
}
