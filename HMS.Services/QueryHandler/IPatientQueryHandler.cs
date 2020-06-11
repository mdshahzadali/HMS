using HMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Services.QueryHandler
{
    public interface IPatientQueryHandler
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientById(int? id);
    }
}
