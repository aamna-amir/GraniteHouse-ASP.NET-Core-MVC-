﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GraniteHouse.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        [Display(Name = ("Sales Person"))]
        public string SalesPersonId { get; set; }
        [ForeignKey("SalesPersonId")]
        public virtual ApplicationUser SalesPerson { get; set; }
        public DateTime AppointmentDate { get; set; }
        [NotMapped]
        public DateTime AppointmentTime { get; set; }
        public string CutomerName { get; set; }
        public string CutomerPhoneNumber { get; set; }
        public string CutomerEmail { get; set; }
        public bool isConfirmed { get; set; }
    }
}
