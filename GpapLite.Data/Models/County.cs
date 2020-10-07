using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GpapLite.Data.Models
{
    public class County
    {
        [Key]
        public string CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<SubCounty> SubCounties { get; set; }
    }
}
