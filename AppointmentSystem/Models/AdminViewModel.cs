
using AppointmentSystem.Data.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class AdminViewModel
    {
        public AppUser User { get; set; }
        
        public IEnumerable<Appointment> GalleryUsers { get; set; }
        public IList<Appointment> Appointment { get; set; }
        public IList<SelectListItem> GalleryUsersSelectList { get; internal set; }
        public IList<Cities> Cities { get; set; }


    }
}
