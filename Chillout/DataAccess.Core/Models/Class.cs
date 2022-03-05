using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chillout.DataAccess.Core.Models
{
    [Table("User Companies")]
    public class Class
    {
        public int Id { get; set; }
        public string CompaniesId { get; set; }
        public UserRto Companies { get; set; }
        public string TimeOfCreateId { get; set; }
        public UserRto TimeOfCreate { get; set; }
        public string PlaceOfCompanyId { get; set; }
        public UserRto PlaceOfCompany { get; set; }
    }
}
