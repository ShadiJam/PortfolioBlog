using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;



public class Blog 
{
   
    public int BlogId { get; set; }
    public string Title { get; set; }
    public List<Post> posts = new List<Post>();
    public Blog() {
        BlogId = new Random().Next();
        posts.Add(new Post { PostId = 1, Title = "Post 1", Content = "Post 1 Content",});
        posts.Add(new Post { PostId = 2, Title = "Post 2", Content = "Post 2 Content",});
        posts.Add(new Post { PostId = 3, Title = "Post 3", Content = "Post 3 Content",});
        posts.Add(new Post { PostId = 4, Title = "Post 4", Content = "Post 4 Content",});
        posts.Add(new Post { PostId = 5, Title = "Post 5", Content = "Post 5 Content",});
        posts.Add(new Post { PostId = 6, Title = "Post 6", Content = "Post 6 Content",});
        posts.Add(new Post { PostId = 7, Title = "Post 7", Content = "Post 7 Content",});
        posts.Add(new Post { PostId = 8, Title = "Post 8", Content = "Post 8 Content",});
        posts.Add(new Post { PostId = 9, Title = "Post 9", Content = "Post 9 Content",});
        posts.Add(new Post { PostId = 10, Title = "Post 10", Content = "Post 10 Content",});
    }
    
}
 /*   public Post Get(int id) {
        return post;
    }
   public IEnumerable<T> TakeLast<T>(IEnumerable<T> posts, int n) {
        if(posts == null)
            throw new ArgumentNullException("posts");
        if(n < 0)
            throw new ArgumentOutOfRangeException("n", "n must be 0 or greater");

        LinkedList<T> temp = new LinkedList<T>();
        
        foreach(var post in posts){
            temp.AddLast(post);
            if(temp.Count > 5)
                temp.RemoveFirst();
        }
        return temp;
    } */



