using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class RelatedParty
    {
        public int ID { get; set; }
        public string RelatedPartyName { get; set; }
        public string RelatedPartyAddress { get; set; }
        public string MobileNoList { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
