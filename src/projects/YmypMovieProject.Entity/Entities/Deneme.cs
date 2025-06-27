using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace YmypMovieProject.Entity.Entities;
public class Deneme : BaseEntity
{
    public Deneme()
    {
        
    }
    public Deneme(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    
}

public record PropertyRecord
{
    public int Id { get; init; }
    public string Name { get; init; }
    public bool IsActive { get; init; }
    public DateTime CreateAt { get; init; }
}