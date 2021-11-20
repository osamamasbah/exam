using Examosama.Controllers;
using Examosama.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contry = Examosama.data.Contry;

namespace Examosama.Models
{
    public class vmcontry
    {
        public List<Contry> Country { set; get; }
        public List<City> city { set; get; }

        public Contry contry { set; get; }

    }
}
