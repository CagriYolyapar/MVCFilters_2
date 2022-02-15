using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters_2.Models.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public string UserName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}