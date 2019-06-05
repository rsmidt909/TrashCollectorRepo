﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string StreetAddress { get; set; }
        public int ZipCode { get; set; }
        public string SpecificPickUpDate { get; set; }
        public string FreezeTimeFrameStart { get; set; }
        public string FreezeTimeFrameEnd { get; set; }
        public int Balance { get; }
        public string State { get; set; }
        public string City { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}