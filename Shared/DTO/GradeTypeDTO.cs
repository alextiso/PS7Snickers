using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class GradeTypeDTO
    {
 
        public int SchoolId { get; set; }
    
        public string GradeTypeCode { get; set; } = null!;
       
        public string Description { get; set; } = null!;
    
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }
      
        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

    }
}

