using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading.Tasks;

[Route("blog")]

public class BlogController : Controller
{
    public IRepository<Blog> blogs; 
    public PostRepo posts;
    public BlogController(IRepository<Blog> blogs, PostRepo posts) {
        this.blogs = blogs;
        this.posts = posts;
    }
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

    [HttpPost("edit/{id}")]
  
    public IActionResult Edit([FromForm]int id){
        Post item = posts.ReadOne(id);
        if(id == 0){
            return BadRequest();
        }
        return View();
    }
    
    [HttpPost("create/new")]

    public IActionResult Create([FromForm]Post p){
        PostRepo posts = new PostRepo();
        posts.Add(p);
        return View();
    }

    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {
      var p = posts.ReadOne(id);
      if (p == null)
        return NotFound();
      posts.Delete(id);
      return new NoContentResult();
    }
}








