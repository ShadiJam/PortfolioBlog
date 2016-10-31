using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[Route("/blog/")]

public class BlogController : Controller
{
    private IRepository<Blog> blogs;
    private IRepository<Post> posts;
    public BlogController(IRepository<Blog> blogs, IRepository<Post> posts) {
        this.blogs = blogs;
        this.posts = posts;
    }


    [HttpGet]
    public IActionResult ReadAll() =>
        View();
        //posts.ReadOne.OrderByDescending(p => p.createdAt).Take(5));

    [HttpGet("/post/{id}")]
    public IActionResult ReadOne(int id) {
        Post item = posts.ReadOne(id);
        if(item == null){
            return NotFound();
        }
        return View(item);
    }

    [HttpGet("/post/new")]
    public IActionResult Create() {
        return View();
    }

 //   [HttpPostAttribute("new")]
  //  [ValidateAntiForgeryToken]
 //   public IActionResult HandleCreate([FromForm] Post p){
 //       p.addNew(new Post { Id = 1, Title = "Post 1", Content = "Post 1 Content",});
  //      return RedirectToAction("ReadAll");
 //   }

    [HttpPost("/post/edit/{id}")]
    public IActionResult Edit([FromBody]Post p){
        if(p == null){
            return BadRequest();
        }
        posts.Create(p);
        return View(p);
    }

  [HttpDelete("/post/delete/{id}")]
  public IActionResult Delete(int id)
  {
      var p = posts.ReadOne(id);
      if (p == null)
        return NotFound();
      posts.Delete(id);
      return RedirectToAction("ReadAll");
  }
}







