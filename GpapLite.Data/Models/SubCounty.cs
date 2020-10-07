using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GpapLite.Data.Models
{
    public class SubCounty
    {
        public int Id { get; set; }

        public string Name { get; set; }


        [Required]
        public int CountyId { get; set; }
        public virtual County County { get; set; }
        public IList<Location> Locations { get; set; }
    }
}
