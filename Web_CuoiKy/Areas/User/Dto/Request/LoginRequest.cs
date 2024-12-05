using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_CuoiKy.Areas.User.Dto.Request
{
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}