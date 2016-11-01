using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



public class BlogController : Controller
{
    private IRepository<Blog> blogs; 
    private PostRepo posts;
    public BlogController(IRepository<Blog> blogs, PostRepo posts) {
        this.blogs = blogs;
        this.posts = posts;
    }
    [Route("blog")]
    [HttpGet]
    public IActionResult GetAll() => 
        View(posts.ReadLast(5));
       

    [HttpGet("{id}")]
    public IActionResult Get(int id) {
        Post item = posts.ReadOne(id);
        if(item == null){
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
  
    public IActionResult Edit([FromForm]Post p){
        if(p == null){
            return BadRequest();
        }
        posts.Create(p);
        return View(p);
    }
    
    [HttpPost("{new}")]

    public IActionResult Create([FromForm]Post p){
        return View();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var p = posts.ReadOne(id);
      if (p == null)
        return NotFound();
      posts.Delete(id);
      return new NoContentResult();
  } 
}








