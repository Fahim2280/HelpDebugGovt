using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class permissionDTO
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string Action { get; set; }

        public string Description { get; set; }
    }
}
