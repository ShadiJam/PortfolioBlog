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
    public Post() {
        Id = new Random().Next();
    }
    public Blog Blog { get; set; }

}