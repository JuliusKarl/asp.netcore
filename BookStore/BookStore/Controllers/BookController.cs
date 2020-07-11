﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View();
        }
        public ViewResult SearchBooks(string title, string authorName) {
            var data = _bookRepository.SearchBook(title, authorName);
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}