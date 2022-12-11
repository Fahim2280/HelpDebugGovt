using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public string BOdy { get; set; }

        public string Status { get; set; }

        public int IssueId { get; set; }

        public int AuthorId { get; set; }
    }
}
