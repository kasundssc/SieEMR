using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telecom { get; set; }
        public byte Gender { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
