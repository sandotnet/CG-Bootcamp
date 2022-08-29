using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst.Entities
{
    public partial class Visit
    {
        public int VisitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? VisitedAt { get; set; }
        public string Phone { get; set; }
    }
}
