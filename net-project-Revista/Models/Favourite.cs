using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Models
{
    public class Favourite : BaseEntity
    {
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }

        public Favourite(string userId, DateTime createdOn)
        {
            UserId = userId;
            CreatedOn = createdOn;
        }
    }
}
