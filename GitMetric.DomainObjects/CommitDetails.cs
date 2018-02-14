using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObjects
{
    public class CommitDetails
    {
        public string Author { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
        public string Branch { get; set; }
    }
}
