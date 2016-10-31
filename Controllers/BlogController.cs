using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[Route("/Blog")]

public class BlogController : Controller 
{
/*[HttpGet("/Get/{id}")]
    public IActionResult get(int id) {
          Post item = Posts.First(p => p.PostId == id);
        if(item == null){
            return NotFound();
        }
        return View(item); 
    }
   */ 
[HttpGet("/GetAll")]
    public IActionResult GetAll() {
        return View();
    }
}






