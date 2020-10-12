using System;
using System.Collections.Generic;
using System.Text;

namespace GpapLite.Data.Models
{
    public class SubCounty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountyId { get; set; }
        public virtual County County { get; set; }
    }
}
