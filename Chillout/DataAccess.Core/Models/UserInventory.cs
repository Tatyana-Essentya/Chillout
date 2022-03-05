using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chillout.DataAccess.Core.Models
{
    [Table("User")]
    public class UserInventory
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string thing { get; set; }
        public string QuantityThing { get; set; }
        public string TypeThing { get; set; }

        public List<UserRto> UserRto { get; set; }
    }
}
