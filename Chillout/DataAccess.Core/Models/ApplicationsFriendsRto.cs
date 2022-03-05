using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chillout.DataAccess.Core.Models
{
    [Table("Applications")]
    public class ApplicationsFriendsRto
    {
        public int Id { get; set; }

        public int UserFirstId { get; set; }
        public int UserSecondId { get; set; }

        public UserRto UserFirst { get; set; }
        public UserRto UserSecond { get; set; }

    }
}
