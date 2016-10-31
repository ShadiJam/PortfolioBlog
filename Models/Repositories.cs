/*
The following is an IRepository pattern. We write our logic to do CRUD operations on a model 
(i.e. in the database, in memory, etc). From our controllers, we can feed the IRepository to
each controller via Dependency Injection:

services.AddSingleton<IRepository<Post>, PostRepo>();

Then each Controller can opt to accept it as an input:

public PostController(DB db, IRepository<Post> r){
    ...
}

*/

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

public interface HasId {
    int Id { get; set; }
}
public interface IRepository<T>
{
    void Create(T item);
    IEnumerable<T> ReadAll();
    T ReadOne(int id);
    void Update(T item);
    T Delete(int id);
}


public class Repo<T> : IRepository<T> where T : class, HasId {

    private static ConcurrentDictionary<int, T> ls = new ConcurrentDictionary<int, T>();
    
    public void Create(T item){
        // item.PostId = Guid.NewGuid(); // to uncommment, will have to change PostId to Guid in the Models
        ls[new Random().Next()] = item;
    }
    
    public IEnumerable<T> ReadAll(){
        return ls.Values;
    }
    
    public T ReadOne(int id){
        return ls[id];
    }
    
    public void Update(T item){
        ls[item.Id] = item;
    }
    
    public T Delete(int id){
        T item;
        ls.TryRemove(id, out item);
        return item;
    }

}
