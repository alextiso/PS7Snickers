using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class SectionDTO
    {
        public int SectionId { get; set; }
  
        public int CourseNo { get; set; }
      
        public byte SectionNo { get; set; }

        public DateTime? StartDateTime { get; set; }
       
        public string? Location { get; set; }
      
        public int InstructorId { get; set; }
    
        public byte? Capacity { get; set; }
       
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }
   
        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }
     
        public int SchoolId { get; set; }
    }
}

