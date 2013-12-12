﻿using Microsoft.AspNet.Mvc;
using Microsoft.Owin;

namespace MvcSample
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Something()
        {
            return new ContentResult
            {
                Content = "Hello World From Content"
            };
        }

        public IActionResult Hello()
        {
            return Result.Content("Hello World");
        }

        public void Raw()
        {
            Context.Response.Write("Hello World raw");
        }
    }
}