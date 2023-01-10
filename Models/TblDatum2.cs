using System;
using System.Collections.Generic;

namespace gChartRazor.Models
{
    public partial class TblDatum2
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public Int32? Tx { get; set; }
        public Int32? Rx { get; set; }
    }
}
