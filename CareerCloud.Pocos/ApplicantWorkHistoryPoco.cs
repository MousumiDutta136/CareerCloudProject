﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos 
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FK_Applicant_Work_Experiences_Applicant_Profiles")]
        public Guid Applicant { get; set; }
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        
        [Column("Country_Code")]
        [ForeignKey("FK_Applicant_Work_History_System_Country_Codes")]
        public string? CountryCode { get; set; }
        public string Location { get; set; }
        [Column("Job_Title")]
        public string JobTitle { get; set; }
        [Column("Job_Description")]
        public string JobDescription { get; set; }
        [Column("Start_Month")]
        public Int16 StartMonth { get; set; }
        [Column("Start_Year")]
        public Int32 StartYear { get; set; }
        [Column("End_Month")]
        public Int16 EndMonth { get; set; }
        [Column("End_Year")]
        public Int32 EndYear { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }

    }
}
