using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examosama.data
{
    [Table("Contry")]
    public class Contry
    {
        public int id { set; get; }
        
        public string name { set; get; }
        public int code { set; get; }
        public List<City> city { set; get; }
    }
}
