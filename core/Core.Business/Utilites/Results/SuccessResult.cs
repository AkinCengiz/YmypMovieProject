using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilites.Results;
//true durumunu temsil eden bir sonuç sınıfıdır. Başarılı işlemler için kullanılır.
public class SuccessResult : Result
{
    public SuccessResult() : base(true)
    {
    }
    public SuccessResult(string message) : base(true, message)
    {
    }
}