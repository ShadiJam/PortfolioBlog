using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;



public class Blog : HasId {
   
    public int Id { get; set; }
    public string Title { get; set; }
    
    public List<Post> posts = new List<Post>();
    
    public Blog(){
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


