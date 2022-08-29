using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst.Entities
{
    public partial class Student
    {
        public int StudId { get; set; }
        public string StudFname { get; set; }
        public string StudLname { get; set; }
        public string Address { get; set; }
        public string TelNo { get; set; }
        public string StudEmail { get; set; }
    }
}
