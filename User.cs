using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    public class User
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        //public int Age { set; get; }
        public int? CompanyId { set; get; }
        public virtual Company? Company { set; get; }
        public int? PositionId { set; get; }
        public virtual Position? Position { set; get; } 

    }
}
