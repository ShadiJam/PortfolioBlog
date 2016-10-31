using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public static class Seed
{
    public static void Initialize(IRepository<Post> posts)
    {
         
      //   posts.Database.EnsureDeleted(); // delete then, ...
      //   posts.Database.EnsureCreated(); // create
        
        // Look for any Posts.
        if (posts == null)
        {
            return; // DB has been seeded already
        }
    
        List<Post> p = new List<Post>();
       
       // List<Blog> blogs = new List<Blog>();
        // Blog mine = new Blog {Url = "mkeas.org"};
        // db.Blogs.Add(mine);
        for(var i = 0; i < 10; i++){
            p.Add(new Post { Title = $"Test Post {i}", Content = $"Test Content {i}" }); // Date=DateTime.Parse("2005-09-01")}
        }

        // Console.WriteLine(db.Database);
     //   posts.SaveChanges();

        // print out the tables 
        Console.WriteLine("----------POSTS SEEDED-------------");
        // Console.WriteLine(db.Blogs.ToList().Count);
    //    Console.WriteLine(db.Posts.ToList().Count);
    }
}
