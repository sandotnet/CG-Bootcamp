using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst.Entities
{
    public partial class ParticipantList
    {
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OfficialEmail { get; set; }
    }
}
