using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api_ef.Models
{
    public class category
    {
        public Guid category_id {get; set;} 
        public string name {get; set;} = string.Empty; 
        public string description {get; set;} = string.Empty;
    }
}