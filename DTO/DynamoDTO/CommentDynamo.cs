using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDynamo
    {
        public string CommentId { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
