using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[Route("/blog")]

public class BlogController : Controller 
{
    public IActionResult get() {
        return View();
    }
    public IActionResult getAll() {
        return View();
    }
}






