using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examosama.data
{
    [Table("City")]
    public class City
    {
        public int id { set; get; }
        
        public string name { set; get; }
       
        public Contry _id { set; get; }

        public Contry contry { set; get; }
       

    }
}
