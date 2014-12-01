//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Find3dPrinting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Printer
    {
        public Printer()
        {
            this.Manufacturers_Printers = new HashSet<Manufacturers_Printers>();
        }
    
        public long Printers_id { get; set; }
        public int NozzleThickness { get; set; }
        public string PrinterName { get; set; }
        public long BoxSize_id { get; set; }
        public long Material_id { get; set; }
        public long ComputeTechnology_id { get; set; }
    
        public virtual BoxSize BoxSize { get; set; }
        public virtual ComputeTechnology ComputeTechnology { get; set; }
        public virtual ICollection<Manufacturers_Printers> Manufacturers_Printers { get; set; }
        public virtual Material Material { get; set; }
    }
}