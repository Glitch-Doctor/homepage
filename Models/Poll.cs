using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glitchdoctor.Models
{
    public class Poll
    {
        public Guid PollId { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Question { get; set; }
        public bool Active { get; set; }
        public bool Live { get; set; }
        public int Result { get; set; }

        public ICollection<PollOptions> Options { get; set; }
        public ICollection<PollResponse> Responses { get; set; }
    }
}
