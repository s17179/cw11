using cw11.Dtos;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class EfDoctorDbService : IDoctorDbService
    {
        private readonly DoctorDbContext _context;

        public EfDoctorDbService(DoctorDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public Doctor AddDoctor(DoctorDto doctorDto)
        {
            var doctor = new Doctor
            {
                FirstName = doctorDto.FirstName,
                LastName = doctorDto.LastName,
                Email = doctorDto.Email
            };

            _context.Add(doctor);

            _context.SaveChanges();

            return doctor;
        }

        public void UpdateDoctor(int doctorId, DoctorDto doctorDto)
        {
            var doctor = _context.Doctors.Find(doctorId);

            doctor.FirstName = doctorDto.FirstName;
            doctor.LastName = doctorDto.LastName;
            doctor.Email = doctorDto.Email;

            _context.SaveChanges();
        }

        public void DeleteDoctor(int doctorId)
        {
            var doctor = _context.Doctors.Find(doctorId);

            _context.Remove(doctor);

            _context.SaveChanges();
        }
    }
}
