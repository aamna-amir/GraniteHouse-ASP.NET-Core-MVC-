using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        [NotMapped]
        public DateTime AppointmentTime { get; set; }
        public string CutomerName { get; set; }
        public string CutomerPhoneNumber { get; set; }
        public string CutomerEmail { get; set; }
        public bool isConfirmed { get; set; }
    }
}
