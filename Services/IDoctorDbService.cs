using cw11.Dtos;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();

        public Doctor AddDoctor(DoctorDto doctorDto);

        public void UpdateDoctor(int doctorId, DoctorDto doctorDto);

        public void DeleteDoctor(int doctorId);
    }
}
