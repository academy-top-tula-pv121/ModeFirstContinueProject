using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    public class Company
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public int CountryId { set; get; }
        public virtual Country? Country { set; get; }
        public virtual List<User> Users { set; get; } = new();
    }
}
