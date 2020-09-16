using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models.ViewModel
{
    public class AppoitmentsViewModel
    {
        public List<Appointments> Appointments { get; set; }
        public PaggingInfo PaggingInfo { get; set; }

    }
}
