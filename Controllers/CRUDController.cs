/*using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public abstract class CRUDController<T> : Controller  
{
    private IRepository<T> r;
    public CRUDController(IRepository<T> r){
        this.r = r;
    }
    [HttpPost]
        public IActionResult C([FromBody] T item) => Ok(r.Create(item));
    
    [HttpGet("{id}")]
        public IActionResult R(int id = -1){
            if(id == -1)
                return Ok(r.Read());
            
            return BadRequest();
        }

    [HttpPut("{id}")]
        public IActionResult U(int id, [FromBody] T item) {
            if(item.Id != id || !r.Update(item))
                return BadRequest();
            
            return Ok();
        }
    [HttpDeleteAttribute("{id}")]
        public IActionResult D(int id) {
            T item = r.Delete(id);
            if(item == null)
            return NotFound();
            return Ok(item);
        }

} */