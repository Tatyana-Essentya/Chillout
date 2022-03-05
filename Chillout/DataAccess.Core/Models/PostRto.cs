using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chillout.DataAccess.Core.Models
{
    [Table("Post")]
    public class PostRto
    {
        public int Id { get; set; }
        public string User { get; set; }
        public UserRto UserId { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string PostText { get; set; }
        public string Reactions { get; set; }
    }
}
