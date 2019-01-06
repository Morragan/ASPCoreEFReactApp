using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farm_ASPCoreEFReactApp.Models
{
    public class Farm
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
