using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[Route("/Blog")]

public class BlogController : Controller 
{
    private Blog blog;
    public BlogController(Blog blog){
        this.blog = blog;
    }

[HttpGet]
    public IActionResult ReadAll() {
        return View(blog);
    }
[HttpGet("{id}")]
    public IActionResult ReadOne(int id) {
        Blog item = blog.Blogs.First(p => p.BlogId == id);
        if(item == null){
            return NotFound();
        }
        return View(item);
    }
}
/*[HttpGet("/Get/{id}")]
    public IActionResult get(int id) {
          Post item = Posts.First(p => p.PostId == id);
        if(item == null){
            return NotFound();
        }
        return View(item); 
    }
   */ 





