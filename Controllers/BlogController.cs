using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

[RouteAttribute("/blog/")]

public class BlogController : Controller
{
    private DB db;
    public BlogController(DB db) {
        this.db = db;
    }

    [HttpGet]
    public IActionResult Get() =>
        View(db.Blogs.OrderBy(b => b.Title).ToList());

    [HttpGetAttribute("{id}")]
    public IActionResult Get(int id) {
        Blog item = db.Blogs.First(b => b.BlogId == id);
        if(item == null){
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
    public IActionResult Post([FromBody]Blog b){
        if(b == null){
            return BadRequest();
        }
        db.Blogs.Add(b);
        db.SaveChanges();
        return View(b);
    }

  [HttpDeleteAttribute("{id}")]
  public IActionResult Delete(int id)
  {
      var b = db.Blogs.First(x => x.BlogId == id);
      if (b == null)
        return NotFound();
      db.Blogs.Remove(b);
      return new NoContentResult();
  }
}







