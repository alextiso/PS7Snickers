using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class InstructorDTO
    {
      
        public int SchoolId { get; set; }
     
        public int InstructorId { get; set; }
     
        public string? Salutation { get; set; }
   
        public string FirstName { get; set; } = null!;
      
        public string LastName { get; set; } = null!;
     
        public string StreetAddress { get; set; } = null!;
    
        public string Zip { get; set; } = null!;
    
        public string? Phone { get; set; }
  
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }
    }
}

