using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public interface HasId {
    int Id { get; set; }
}
public interface IRepository<T>
{
 //   void Create(T item);
    IEnumerable<T> ReadAll();
    T ReadOne(int id);
//    void Update(T item);
    T Delete(int id); 
}


public class Repo<T> : IRepository<T> where T : class, HasId {

    public static ConcurrentDictionary<int, T> ls = new ConcurrentDictionary<int, T>();
    
    public void Create(T item){
        // item.PostId = Guid.NewGuid(); // to uncommment, will have to change PostId to Guid in the Models
        ls[new Random().Next()] = item;
 //       ls.Add<T>(item);
    }
    
    public IEnumerable<T> ReadAll(){
        return ls.Values;
    }
    
    public T ReadOne(int id){
        return ls[id];
    }
    
//    public void Update(T item){
//        ls[item.Id] = item;
        
 //   }
    
    public T Delete(int id){
        T item;
        ls.TryRemove(id, out item);
        return item;
    }

    public IEnumerable<T> getAll(){
        return (ls.Values);
    }

    public T get(int id){
        return ls[id];
    }
    
}

public class PostRepo : Repo<Post> {
    public PostRepo() : base(){}
    public IEnumerable<Post> ReadLast(int n) {
        return ls.Values.OrderByDescending(b => b.createdAt).Take(n);
        }
    public IEnumerable<Post> Add(Post p) {
       List<Post> posts = new List<Post>();
       ls[new Random().Next()] = p;
       posts.Add(p);
       return ls.Values;
       
    }
}

