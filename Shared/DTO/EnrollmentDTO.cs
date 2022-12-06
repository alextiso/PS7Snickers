using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SNICKERS.EF.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class EnrollmentDTO
    {
        public int StudentId { get; set; }

        public int SectionId { get; set; }

        public DateTime EnrollDate { get; set; }

        public byte? FinalGrade { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

        public int SchoolId { get; set; }
    }
}

