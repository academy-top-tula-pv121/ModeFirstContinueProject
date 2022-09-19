using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    public class Position
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public virtual List<User> Users { set; get; } = new();
    }
}
