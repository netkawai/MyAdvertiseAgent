using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdvertiseAgent.Models
{
    public class AdvOrder
    {
        public int Id { get; set; }

        public string Customer { get; set; }

        public uint NumOfPage { get; set; }

        public virtual ContentTypePrice ContentPrice { get; set; }

        public virtual PageTypePrice PagePrice { get; set; }

        public virtual Employee OrderedEmployee { get; set; }

    }
}
