using System;

namespace CodeBaseWeb.Models
{
    public class Auditable
    {
        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set;} 

        public DateTime ModifiedAt { get; set; }

        public int ModifiedBy { get; set;} 
    }
}