using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class Post : HasId
{
    // sometimes, people use Guids
    public int Id { get; set; }
    // [required] - we can require some attributes - throw errors if the model isn't valid
    public string Title { get; set; }
    public string Content { get; set; } 
    // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime createdAt { get; set; } 
    public Blog Blog { get; set; }
    private List<Post> posts = new List<Post>();
    public Post() {
        Id = new Random().Next();
    }
        public void add(Post p){
        posts.Add(p);
    }
    public IEnumerable<Post> getAll(){
        return (posts.OrderByDescending(p => p.createdAt).Take(5));
    }
    public Post get(int id){
        return posts.First(p => p.Id == id);
    }
    public Post update(int id, Post p){
        Post toUpdate = posts.First(x => x.Id == id);
        if(toUpdate != null){
            posts.Remove(toUpdate);
            posts.Add(p);
            return p;
        }
        return null;
    }
    public void delete(int id){
        Post p = posts.First(x => x.Id == id);
        if(p != null){
            posts.Remove(p);
        }
    }
}
