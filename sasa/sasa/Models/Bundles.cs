using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sasa.Models
{
    public class Bundles
    {
        public int apple { get; set; }
        public int radish { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime WorkDate { get; set; }
   
        

    }
}
