using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sasa.Models
{
    public class User
    {
        public string name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public EmailAddressAttribute email { get; set; }
    }
}
