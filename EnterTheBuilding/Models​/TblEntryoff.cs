using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EnterTheBuilding.Models​
{
    public partial class TblEntryoff
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }
        [Range(typeof(decimal), "35.0", "45.0")]
        public decimal? Temp { get; set; }
        public string Loc { get; set; }
        public string Covid { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? CurDate { get; set; }
    }
}
