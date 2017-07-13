using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glitchdoctor.Models
{
    public class PollOptions
    {
        public Guid PollId { get; set; }
        public int ResponseId { get; set; }
        public string Response { get; set; }
    }
}
