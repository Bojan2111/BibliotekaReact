using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Models.Login
{
    public class TokenDTO
    {
        public string? Username { get; set; }
        public string? Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
