using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksMangment.Models;

namespace BooksMangment.Controllers
{
    public class booksController : Controller
    {
        public static List<Book> books;

        // GET: books
        public ActionResult Index()
        {
            if (books == null)
            {
                books = new List<Book>();

                books.Add(new Book {id=1 ,auther="waleed",title="reach",price=10.54m });
                books.Add(new Book { id = 2, auther = "mohamed", title = "for", price = 10.54m });
                books.Add(new Book { id = 3, auther = "hassanen", title = "the stars", price = 10.54m });

            }
            return View(books);
        }

        // GET: books/Details/5
        public ActionResult Details(int id)
        {
            Book book = books.Single(w => w.id == id);

            return View(book);
        }

        // GET: books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: books/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here

                books.Add(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: books/Edit/5
        public ActionResult Edit(int Id)
        {
            Book book = books.Single(a => a.id == Id);
           
            return View(book);
        }

        // POST: books/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, Book book)
        {
            try
            {
                // TODO: Add update logic here
                Book oldbook = books.Single(a => a.id == Id);
                oldbook.auther = book.auther;
                oldbook.title = book.title;
                oldbook.price = book.price;


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: books/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = books.Single(s => s.id == id);
            return View(book);
        }

        // POST: books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Book book = books.Single(s => s.id == id);
                books.Remove(book);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
