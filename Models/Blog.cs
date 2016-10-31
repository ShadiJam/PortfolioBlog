using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;



public class Blog {
   
    public int BlogId { get; set; }
    public string title { get; set; }
    
    private List<Post> posts = new List<Post>();
    
    public Blog(){
        posts.Add(new Post { Title = "Blog 1", Content = "This is the first blog post - I will be updating content shortly", PostId = 1,});
        posts.Add(new Post { Title = "Blog 2", Content = "This is the second blog post - I will be updating content shortly", PostId = 2,});
        posts.Add(new Post { Title = "Blog 3", Content = "This is the third blog post - I will be updating content shortly", PostId = 3,});
        posts.Add(new Post { Title = "Blog 4", Content = "This is the fourth blog post - I will be updating content shortly", PostId = 4,});
        posts.Add(new Post { Title = "Blog 5", Content = "This is the fifth blog post - I will be updating content shortly", PostId = 5,});
        posts.Add(new Post { Title = "Blog 6", Content = "This is the sixth blog post - I will be updating content shortly", PostId = 6,});
        posts.Add(new Post { Title = "Blog 7", Content = "This is the seventh blog post - I will be updating content shortly", PostId = 7,});
        posts.Add(new Post { Title = "Blog 8", Content = "This is the eighth blog post - I will be updating content shortly", PostId = 8,});
        posts.Add(new Post { Title = "Blog 9", Content = "This is the ninth blog post - I will be updating content shortly", PostId = 9,});
        posts.Add(new Post { Title = "Blog 10", Content = "This is the tenth blog post - I will be updating content shortly", PostId = 10,});
        int BlogId = new Random().Next();
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
}


