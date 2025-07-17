using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Entity.Concrete;
using YmypMovieProject.DataAccess.Contexts;
using YmypMovieProject.DataAccess.Repositories.Abstract;

namespace YmypMovieProject.DataAccess.Repositories.Concrete.EntityFramework;
public class EfUserRepository : EfGenericRepository<User,MovieDbContext>,IUserRepository
{
    public EfUserRepository(MovieDbContext context) : base(context)
    {
    }

    public List<OperationClaim> GetOperationClaims(User user)
    {
        var claims = from operationClaim in Context.OperationClaims
            join userOperationClaim in Context.UserOperationClaims
                on operationClaim.Id equals userOperationClaim.OperationClaimId
            where userOperationClaim.UserId == user.Id
            select new OperationClaim()
            {
                Id = operationClaim.Id,
                Name = operationClaim.Name
            };
        return claims.ToList();
    }
}
