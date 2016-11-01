using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;



public class Blog : HasId
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Post> posts = new List<Post>();

    public Blog() {
        Id = new Random().Next();
        posts.Add(new Post { Id = 1, Title = "Post 1", Content = "Post 1 Content",});
        posts.Add(new Post { Id = 2, Title = "Post 2", Content = "Post 2 Content",});
        posts.Add(new Post { Id = 3, Title = "Post 3", Content = "Post 3 Content",});
        posts.Add(new Post { Id = 4, Title = "Post 4", Content = "Post 4 Content",});
        posts.Add(new Post { Id = 5, Title = "Post 5", Content = "Post 5 Content",});
        posts.Add(new Post { Id = 6, Title = "Post 6", Content = "Post 6 Content",});
        posts.Add(new Post { Id = 7, Title = "Post 7", Content = "Post 7 Content",});
        posts.Add(new Post { Id = 8, Title = "Post 8", Content = "Post 8 Content",});
        posts.Add(new Post { Id = 9, Title = "Post 9", Content = "Post 9 Content",});
        posts.Add(new Post { Id = 10, Title = "Post 10", Content = "Post 10 Content",});
    }    
}


