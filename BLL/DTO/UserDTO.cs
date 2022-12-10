using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string DispalayName { get; set; }

        public string Password { get; set; }

        public int DisplayImageId { get; set; }

        public string Email { get; set; }
    }
}
