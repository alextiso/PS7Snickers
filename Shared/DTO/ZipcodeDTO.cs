using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNICKERS.Shared.DTO
{
    public class ZipcodeDTO
    {
        public string Zip { get; set; } = null!;
      
        public string? City { get; set; }
        
        public string? State { get; set; }
      
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }
       
        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; }

    }
}

