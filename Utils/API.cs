using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;

internal static class API {
    public static async Task<string> GetJSON(string url) =>
        await new HttpClient().GetStringAsync(url);
    
    public static async Task<T> GetData<T>(string url) => 
        JsonConvert.DeserializeObject<T>( await GetJSON(url) );
    
    public static string ToJSON(Object o) => JsonConvert.SerializeObject(o);
}
/*[Route("/api/")]
public abstract class CRUDController<T> : Controller where T : class, HasId {
    public CRUDController(IRepository<T> t) : base (t) {}
}
//[Route("/api/posts")]
public class PostController : CRUDController<Post> {
    public PostController(IRepository<Post> posts) : base (posts) {}
}
//[Route("/api/blogs")]
public class BlogController : CRUDController<Blog> {
    public BlogController(IRepository<Blog> blogs) : base (blogs) {}
}
*/