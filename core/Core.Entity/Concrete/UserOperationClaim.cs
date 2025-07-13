using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete;
public class UserOperationClaim : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid OperationClaimId { get; set; }
}
