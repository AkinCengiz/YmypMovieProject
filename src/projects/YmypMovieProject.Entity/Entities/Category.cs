using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace YmypMovieProject.Entity.Entities;
public sealed class Category : BaseEntity
{
    public Category()
    {
        Movies = new HashSet<Movie>();
    }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Movie> Movies { get; set; }

}
