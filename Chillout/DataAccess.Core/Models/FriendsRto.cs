using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chillout.DataAccess.Core.Models
{
    [Table("Friends")]
    public class FriendsRto
    {
        public int Id { get; set; }
        public string FriendName { get; set; }
        public string FriendSecondName { get; set; }

        public int LeftFriendId { get; set; }
        public UserRto LeftFriend { get; set; }
        public int RightFriendId { get; set; }
        public UserRto RightFriend { get; set; }
        public int WhosFriendId { get; set; }
        public UserRto  WhosFriend{ get; set; }
    }
}
