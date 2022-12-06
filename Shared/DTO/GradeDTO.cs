using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class GradeDTO
    {
        public int SchoolId { get; set; }

        public int StudentId { get; set; }
      
        public int SectionId { get; set; }
  
        public string GradeTypeCode { get; set; } = null!;
        
        public byte GradeCodeOccurrence { get; set; }
    
        public decimal NumericGrade { get; set; }
 
        public string? Comments { get; set; }
 
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;
       
        public DateTime ModifiedDate { get; set; }
    }
}

