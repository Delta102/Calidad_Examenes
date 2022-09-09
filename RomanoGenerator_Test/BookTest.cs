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

            book.Name = "Harry Potter II";
            book.Price = 61.0m;

            bookStore.AddToCart(book);

            var result=bookStore.GetTotal();

            Assert.AreEqual(116m, result);
        }

        [Test]
        public void Caso02()
        {

        }

        [Test]
        public void Caso03()
        {

        }

        [Test]
        public void Caso04()
        {

        }

        [Test]
        public void Caso05()
        {

        }

        [Test]
        public void Caso06()
        {

        }

        [Test]
        public void Caso07()
        {

        }

        [Test]
        public void Caso08()
        {

        }

        [Test]
        public void Caso09()
        {

        }

        [Test]
        public void Caso10()
        {

        }

    }
}
