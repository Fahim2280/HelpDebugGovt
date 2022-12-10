using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class IssueDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Status { get; set; }

        public int UserId { get; set; }

        public int OrganizationId { get; set; }
    }
}
