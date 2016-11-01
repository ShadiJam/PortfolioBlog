using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[Route("/blog/")]

public class BlogController : Controller
{
    private List<Blog> blogs;
    private List<Post> posts;
    public BlogController(List<Blog> blogs, List<Post> posts) {
        this.blogs = blogs;
        this.posts = posts;
    }

    [HttpGet("/blog/")]
    public IActionResult ReadAll() {
       return View(posts.getAll());
    }

    [HttpGet("/post/{id}")]
    public IActionResult ReadOne(int id) {
        var post = posts.Get(id);
        if(post == null){
            return NotFound();
        }
        return View(post);
    }

    [HttpGet("/post/new")]
    public IActionResult Create() {
        return View();
    }

    [HttpPostAttribute("new")]
    [ValidateAntiForgeryToken]
    public IActionResult HandleCreate([FromForm] Post p){
        p.add(new Post { Id = 1, Title = "Post 1", Content = "Post 1 Content",});
        return RedirectToAction("ReadAll");
    }

    [HttpPost("/post/edit/{id}")]
    public IActionResult Edit([FromBody]Post p){
        if(p == null){
            return BadRequest();
        }
        posts.Add(p);
        return View(p);
    }

  [HttpDelete("/post/delete/{id}")]
  public IActionResult Delete(int id)
  {
      var p = posts.Get(id);
      if (p == null)
        return NotFound();
      posts.Remove(p);
      return RedirectToAction("ReadAll");
  }
}







