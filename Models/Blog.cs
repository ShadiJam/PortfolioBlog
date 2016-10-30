using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public interface IBlog {
    void add(Post p);
    IEnumerable<Post> getAll();
}

public class Blog : IBlog {
   
    public int BlogId { get; set; }
    public string title { get; set; }
    
    private List<Post> posts = new List<Post>();
    
    public Blog(){
        posts.Add(new Post { Title = "Blog 1", Content = "This is the first blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 2", Content = "This is the second blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 3", Content = "This is the third blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 4", Content = "This is the fourth blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 5", Content = "This is the fifth blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 6", Content = "This is the sixth blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 7", Content = "This is the seventh blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 8", Content = "This is the eighth blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 9", Content = "This is the ninth blog post - I will be updating content shortly"});
        posts.Add(new Post { Title = "Blog 10", Content = "This is the tenth blog post - I will be updating content shortly"});
        int BlogId = new Random().Next();
    }
    public void add(Post p){
        posts.Add(p);
    }
    public IEnumerable<Post> getAll() {
        return posts;
    }
}

