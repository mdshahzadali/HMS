using HMS.Core.DbContexts;
using HMS.Core.Models;
using HMS.Services.QueryHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.Data.QueryHandler
{
    public class PatientQueryHandler : IPatientQueryHandler
    {
        private readonly HMSDbContext _context;

        public PatientQueryHandler(HMSDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientById(int? id)
        {
            if(id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _context.Patients.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
