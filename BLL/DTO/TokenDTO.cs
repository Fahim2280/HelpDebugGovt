﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTO
{
    public class TokenDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string AccessToken { get; set; }

        public System.DateTime CreatedAt { get; set; }

        public System.DateTime ExpiredAt { get; set; }
    }
}
