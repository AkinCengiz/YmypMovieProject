using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilites.Security.Jwt;
public class TokenOptions
{
    public string Audience { get; set; } // Token kullanıcı listesi
    public string Issuer { get; set; } // Token imzalayan
    public int AccessTokenExpiration { get; set; } // Dakika cinsinden süre
    public string SecurityKey { get; set; } // Güvenlik anahtarı
}
