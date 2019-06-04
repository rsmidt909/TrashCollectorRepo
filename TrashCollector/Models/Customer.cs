using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Firstname { get; set; }
        public int Lastname { get; set; }
        public string StreetAddress { get; set; }
        public int ZipCode { get; set; }
        public string SpecificPickUpDate { get; set; }
        public string FreezeTimeFrame { get; set; }
    }
}