using HMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Services.CommandHandler
{
    public interface IPatientCommandHandler
    {
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}
