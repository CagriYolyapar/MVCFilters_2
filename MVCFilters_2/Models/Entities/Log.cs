using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters_2.Models.Entities
{
    public class Log:BaseEntity
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Information { get; set; }
        public Keyword Description { get; set; }
    }

    public enum Keyword
    {
        Entry = 1, Exit = 2
    }
}