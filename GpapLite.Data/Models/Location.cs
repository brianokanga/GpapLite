using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GpapLite.Data.Models
{
    public class Location
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int SubCountyId { get; set; }
        public virtual SubCounty SubCounty { get; set; }
        //public IList<Specie> Species { get; set; }
    }
}
