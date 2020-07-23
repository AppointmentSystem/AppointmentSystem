using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class AddOrUpdateAppointmentModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string il { get; set; }
        public string Plaka { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string Description { get; set; }
    }
}
