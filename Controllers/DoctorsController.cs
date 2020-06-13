using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Dtos;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorDbService _doctorDbService;

        public DoctorsController(IDoctorDbService doctorDbService)
        {
            _doctorDbService = doctorDbService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_doctorDbService.GetDoctors());
        }

        [HttpPost]
        public IActionResult CreateDoctor(DoctorDto doctorDto)
        {
            var doctor = _doctorDbService.AddDoctor(doctorDto);

            return Created("", doctor);
        }

        [HttpPut("{doctorId}")]
        public IActionResult UpdateDoctor(int doctorId, DoctorDto doctorDto)
        {
            _doctorDbService.UpdateDoctor(doctorId, doctorDto);

            return Ok();
        }

        [HttpDelete("{doctorId}")]
        public IActionResult DeleteDoctor(int doctorId)
        {
            _doctorDbService.DeleteDoctor(doctorId);

            return Ok();
        }
    }
}
