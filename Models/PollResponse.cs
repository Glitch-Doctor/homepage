using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glitchdoctor.Models
{
    public class PollResponse
    {
        public Guid PollId { get; set; }
        public string UserName { get; set; }
        public int ResponseNum { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
