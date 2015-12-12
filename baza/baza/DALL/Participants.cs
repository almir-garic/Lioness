using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza.DALL
{
   public class Participants
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int teamId { get; set; }
        public virtual Team Team { get; set; }

    }
}
