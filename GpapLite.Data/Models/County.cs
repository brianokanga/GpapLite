using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GpapLite.Data.Models
{
    public class County
    {
      
        public string CountryId { get; set; }

        public string Name { get; set; }

        public ICollection<SubCounty> SubCounties { get; set; }
    }
}
