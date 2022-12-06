using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class GradeConversionDTO
    {
        public int SchoolId { get; set; }
     
        public string LetterGrade { get; set; } = null!;

        public decimal GradePoint { get; set; }

        public byte MaxGrade { get; set; }

        public byte MinGrade { get; set; }
   
        public string CreatedBy { get; set; } = null!;
    
        public DateTime CreatedDate { get; set; }
  
        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

    }
}

