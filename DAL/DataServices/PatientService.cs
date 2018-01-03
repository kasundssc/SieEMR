using System;

namespace DAL
{
    public class PatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
