using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.Core.Models;
using HMS.Services.CommandHandler;
using HMS.Services.QueryHandler;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Api.Controllers
{
    [Route("api/Patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientQueryHandler _patientQueryHandler;
        private readonly IPatientCommandHandler _patientCommandHandler;

        public PatientController(IPatientQueryHandler patientQueryHandler ,IPatientCommandHandler patientCommandHandler)
        {
            _patientQueryHandler = patientQueryHandler;
            _patientCommandHandler = patientCommandHandler;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetAllPatients()
        {
            var patientResult = _patientQueryHandler.GetAllPatients();
            return Ok(patientResult);
        }
        [HttpGet("{id}")]
        public ActionResult<Patient> GetPatientById(int ? id)
        {
            var result = _patientQueryHandler.GetPatientById(id);
            return Ok(result);
        }
        [HttpPost]
        public ActionResult<Patient> AddPatient(Patient patient)
        {
            _patientCommandHandler.AddPatient(patient);
            return Ok(patient);
        }
    }
}