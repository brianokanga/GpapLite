using System;
using System.Collections.Generic;
using System.Text;

namespace GpapLite.Data.Models
{
    public class PlantRequest
    {
        public int Id { get; set; }

        public int CountyId { get; set; }
        public virtual County County { get; set; }
    }
}
