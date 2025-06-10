using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity;
public abstract class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? UpdateAt { get; set; }
    public bool IsActive { get; set; } 
    public bool IsDeleted { get; set; } 

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CreateAt = DateTime.UtcNow;
        UpdateAt = null;
        IsActive = true;
        IsDeleted = false;
    }
}
