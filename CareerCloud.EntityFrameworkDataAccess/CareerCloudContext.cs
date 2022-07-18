using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
       public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
       public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
       public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
       public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
       public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
       public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
       public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
       public DbSet<CompanyJobDescriptionPoco> CompanyJobsDescriptions { get; set; }
       public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
       public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
       public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
       public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
       public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
       public DbSet<SecurityLoginsLogPoco> SecurityLoginsLog { get; set; }
       public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
       public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
       public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
       public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            var connectionString = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>(entity =>
                 {
                     entity.HasOne(ap => ap.ApplicantProfile)
                  .WithMany(ae => ae.ApplicantEducations)
                  .HasForeignKey(k => k.Applicant);
                 });

            modelBuilder.Entity<ApplicantJobApplicationPoco>(
                entity => {
                    entity.HasOne(ap => ap.ApplicantProfile)
         .WithMany(ae => ae.ApplicantJobApplications)
         .HasForeignKey(k => k.Applicant); }
               
                );

            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
                {
                    entity.HasOne(cj => cj.CompanyJob)
                  .WithMany(aja => aja.ApplicantJobApplications)
                  .HasForeignKey(f => f.Job);
                }
               
            );

            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
                {
                    entity.HasOne(sl => sl.SecurityLogin)
                  .WithMany(ap => ap.ApplicantProfiles)
                  .HasForeignKey(f => f.Login);
                }
               
            );
            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
               {
                   entity.HasOne(sc => sc.SystemCountryCode)
                  .WithMany(ap => ap.ApplicantProfiles)
                  .HasForeignKey(f => f.Country);
               }
                
            );
          

            modelBuilder.Entity<ApplicantResumePoco>(entity =>
               {
                   entity.HasOne(ap => ap.ApplicantProfile)
                  .WithMany(ar => ar.ApplicantResumes)
                  .HasForeignKey(f => f.Applicant);
               }
                
            );

            modelBuilder.Entity<ApplicantSkillPoco>(entity =>
                {
                    entity.HasOne(ap => ap.ApplicantProfile)
                  .WithMany(ask => ask.ApplicantSkills)
                  .HasForeignKey(f => f.Applicant);
                }
                
            );

            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
                {
                    entity.HasOne(ap => ap.ApplicantProfile)
                  .WithMany(awh => awh.ApplicantWorkHistorys)
                  .HasForeignKey(f => f.Applicant);
                }
               
            );
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
                {
                    entity.HasOne(scc => scc.SystemCountryCode)
                  .WithMany(awh => awh.ApplicantWorkHistories)
                  .HasForeignKey(f => f.CountryCode);
                }
                
            );

            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
                {
                    entity.HasOne(cp => cp.CompanyProfile)
                  .WithMany(cd => cd.CompanyDescriptions)
                  .HasForeignKey(f => f.Company);
                }
                
            );
            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
                {
                    entity.HasOne(slc => slc.SystemLanguageCode)
                  .WithMany(cd => cd.CompanyDescriptions)
                  .HasForeignKey(f => f.LanguageId);
                }
               
            );

            modelBuilder.Entity<CompanyJobDescriptionPoco>(entity =>
                entity.HasOne(cj => cj.CompanyJob)
                .WithMany(cjd => cjd.CompanyJobDescriptions)
                .HasForeignKey(f => f.Job)
                
            );

            modelBuilder.Entity<CompanyJobEducationPoco>(entity =>
                {
                    entity.HasOne(cj => cj.CompanyJob)
                  .WithMany(cje => cje.CompanyJobEducations)
                  .HasForeignKey(f => f.Job);
                }
              
            );

            modelBuilder.Entity<CompanyJobPoco>(entity =>
               {
                   entity.HasOne(cp => cp.CompanyProfile)
                  .WithMany(cj => cj.CompanyJobs)
                  .HasForeignKey(f => f.Company);
               }
                
            );

            modelBuilder.Entity<CompanyJobSkillPoco>(entity =>
                {
                    entity.HasOne(cj => cj.CompanyJob)
                  .WithMany(cjs => cjs.CompanyJobSkills)
                  .HasForeignKey(f => f.Job);
                }
                
            );

            modelBuilder.Entity<CompanyLocationPoco>(entity =>
                {
                    entity.HasOne(cp => cp.CompanyProfile)
                  .WithMany(cl => cl.CompanyLocations)
                  .HasForeignKey(f => f.Company);
                }
                
            );

            modelBuilder.Entity<CompanyLocationPoco>(entity =>
            {
                entity.HasOne(scd => scd.SystemCountryCode)
              .WithMany(cl => cl.CompanyLocations)
              .HasForeignKey(f => f.CountryCode);
            }

           );


            modelBuilder.Entity<SecurityLoginsLogPoco>(entity =>
                {
                    entity.HasOne(sl => sl.SecurityLogin)
                  .WithMany(sll => sll.SecurityLoginsLogs)
                  .HasForeignKey(f => f.Login);
                }
                
            );

            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
               {
                   entity.HasOne(sl => sl.SecurityLogin)
                  .WithMany(slr => slr.SecurityLoginsRoles)
                  .HasForeignKey(f => f.Login);
               }
               
            );
            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
               {
                   entity.HasOne(sr => sr.SecurityRole)
                  .WithMany(slr => slr.SecurityLoginsRoles)
                  .HasForeignKey(f => f.Role);
               }
               
            );


            modelBuilder.Entity<ApplicantEducationPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<ApplicantProfilePoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<ApplicantJobApplicationPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<ApplicantSkillPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<ApplicantWorkHistoryPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyDescriptionPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyJobSkillPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyJobPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyJobEducationPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyJobDescriptionPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyLocationPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<CompanyProfilePoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<SecurityLoginPoco>().Ignore(c => c.TimeStamp);
            modelBuilder.Entity<SecurityLoginsRolePoco>().Ignore(c => c.TimeStamp);


            base.OnModelCreating(modelBuilder);
        }
    }
}
