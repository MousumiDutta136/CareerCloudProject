﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FK_Company_Job_Skills_Company_Jobs")]
        public Guid Job { get; set; }
        public string Skill { get; set; }
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        public Int32 Importance { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

        public virtual CompanyJobPoco CompanyJob { get; set; }

    }
}
