using System;
using System.Collections.Generic;

namespace Api.Src.Modules.Doctor.Domain.Dtos
{
    public class FindAppointmentDto
    {
        public List<int> MedicoIds { get; set; }
        public List<int> Crms { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
