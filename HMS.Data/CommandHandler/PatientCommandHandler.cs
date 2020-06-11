using HMS.Core.DbContexts;
using HMS.Core.Models;
using HMS.Services.CommandHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Data.CommandHandler
{
    public class PatientCommandHandler : IPatientCommandHandler
    {
        private readonly HMSDbContext _context;

        public PatientCommandHandler(HMSDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddPatient(Patient patient)
        {
            if(patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void DeletePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
