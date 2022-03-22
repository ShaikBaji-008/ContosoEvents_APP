using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contoso_User_API.Model;

namespace Contoso_User_API.Data
{
   
    public class DataConnectionContext  : DbContext
    {
        public DataConnectionContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User>Users { get; set; }

        //public DbSet<AppUser> AppUsers { get; set; }
        //public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Consultation> Consultations { get; set; }
        //public DbSet<DoctorAvailableTimings> DoctorAvailableTiming { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //public DbSet<Appointments> Appointment { get; set; }

    }
    //public class EConsultContext : DbContext
    //{
    //    public EConsultContext(DbContextOptions options)
    //      : base(options)
    //    {

    //    }
    //    public DbSet<AppUser> AppUsers { get; set; }
    //    public DbSet<Doctor> Doctors { get; set; }
    //    public DbSet<Consultation> Consultations { get; set; }
    //    public DbSet<DoctorAvailableTimings> DoctorAvailableTiming { get; set; }
    //    public DbSet<Review> Reviews { get; set; }
    //    public DbSet<Appointments> Appointment { get; set; }
    //}


}
