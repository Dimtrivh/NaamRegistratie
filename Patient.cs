using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Patientendossier.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; } 
        public string FirstName { get; set; }
        public int BirthYear { get; set; }

    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Patient> Patienten { get; set; }
    }


    public class dossier 
    {
        public int DossierNr { get; set; }


    }


}               