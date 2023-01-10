using System;
using System.Collections.Generic;

namespace gChartRazor.Models
{
    public partial class TblDatum
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Tx { get; set; }
        public string? Rx { get; set; }
    }
}
