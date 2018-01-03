using System;
using System.Collections.Generic;
using EMR.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RelatedParty> GetAllPatients()
        {
            IEnumerable<RelatedParty> patientList = _context.RelatedParty;
            return patientList;
        }
    }
}
