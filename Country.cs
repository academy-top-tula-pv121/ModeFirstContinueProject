using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    public class Country
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public int CapitalId { set; get; }
        public virtual City? Capital { set; get; }
        public virtual List<Company> Companies { set; get; } = new();
    }
}
