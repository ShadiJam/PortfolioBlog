using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[RouteAttribute("/blog/")]

public class BlogController : Controller
{
    private IRepository<Blog> blogs;
    private IRepository<Post> posts;
    public BlogController(IRepository<Blog> blogs, IRepository<Post> posts) {
        this.blogs = blogs;
        this.posts = posts;
    }

    [HttpGet]
    public IActionResult Get() =>
        View(posts.Read().OrderByDescending(b => b.createdAt).Take(5));

    [HttpGet("{id}")]
    public IActionResult Get(int id) {
        Post item = posts.Read(id);
        if(item == null){
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
    public IActionResult Post([FromBody]Post p){
        if(p == null){
            return BadRequest();
        }
        posts.Create(p);
        return View(p);
    }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
      var p = posts.Read(id);
      if (p == null)
        return NotFound();
      posts.Delete(id);
      return new NoContentResult();
  }
}







