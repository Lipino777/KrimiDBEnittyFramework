using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;


namespace KrimiDBEnittyFramework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
            CrDbContext db = new CrDbContext();
            db.People.Add(new krimiPerson { personFirstName = "Petr", personLastName = "Spacek", personCrimeCount = 1000 });
            db.SaveChanges();
            ////var temPersonC = db.People.Where(t => t.personFirstName == "petr" && t.personLastName == "Spacek").Select(t => t.personID).FirstOrDefault();
            //var temPersonC = db.People.OrderByDescending(t => t.personID).Select(t => t.personID).FirstOrDefault();

            //db.People.Add(new krimiPerson { personFirstName = "Tomas", personLastName = "lipavsky", personCrimeCount = 23 });
            //db.SaveChanges() ;
            ////var temPersonV = db.People.Where(t => t.personFirstName == "Tomas" && t.personLastName == "lipavsky").Select(t=> t.personID).FirstOrDefault();
            //var temPersonV = db.People.OrderByDescending(t => t.personID).Select(t => t.personID).FirstOrDefault();

            //db.Leads.Add(new krimiLead { leadAddress = "Hradecka 119", leadDescription = "Mr Mach knows but doesn't do crap about it"});
            //db.SaveChanges() ;
            //var temLead = db.Leads.OrderByDescending(t => t.leadID).Select(t => t.leadID).FirstOrDefault();

            //db.Investigations.Add(new krimiInvestigation {investigationSuspectID = temPersonC, investigationLeadID = temLead });
            //db.SaveChanges() ;
            //var temInvestigation= db.Leads.OrderByDescending(t => t.leadID).Select(t => t.leadID).FirstOrDefault();

            //db.Crimes.Add(new krimiCrime { crimeAlias = "case of the bully", crimeDescript = "hidden intentional attacks during PE", crimeInvestigID = temInvestigation, crimeVictimID = temPersonV });
            //db.SaveChanges();






        }
    }
    class CrDbContext : DbContext
    {
        public CrDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=krimiDatabase;Trusted_Connection=True; Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<krimiCrime> Crimes { get; set; }
        public virtual DbSet<krimiInvestigation> Investigations { get; set;}
        public virtual DbSet<krimiLead> Leads { get; set; }
        public virtual DbSet<krimiPerson> People { get; set; }

    }
    class krimiCrime()
    {
        [Key]
        public int crimeID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string crimeAlias { get; set; }

        public int crimeVictimID { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string crimeDescript { get; set; }

        public int crimeInvestigID { get; set; }
    }
    class krimiInvestigation()
    {
        [Key]
        public int investigationID { get; set; }
        public int investigationSuspectID { get; set; }
        public int investigationLeadID { get; set; }
    }
    class krimiLead()
    {
        [Key]
        public int leadID { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string leadAddress { get; set; }

        public string leadDescription { get; set; }
    }
    class krimiPerson()
    {
        [Key]
        public int personID { get; set;}

        [Column(TypeName ="nvarchar(30)")]
        public string personFirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string personLastName { get; set; }

        [Column(TypeName ="image")]
        public byte[] personFingerprint { get; set; }

        public int personCrimeCount { get; set; }
    }
}