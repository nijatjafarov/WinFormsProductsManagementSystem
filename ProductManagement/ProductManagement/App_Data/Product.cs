//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagement.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SaleOrRent { get; set; }
        public string MeasurementUnit { get; set; }
        public double Measure { get; set; }
        public double BuyingPrice { get; set; }
        public Nullable<double> SalePrice { get; set; }
    }
}
