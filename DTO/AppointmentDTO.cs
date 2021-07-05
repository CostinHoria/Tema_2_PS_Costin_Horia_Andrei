using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tema2_NoLogin.Models;

namespace Tema2_NoLogin.DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public String Name_client { get; set; }
        public String Phone_number { get; set; }
        public DateTime Appointment_date { get; set; }
        public double Total { get; set; }
        public List<Service> Services { get; set; }

        public string AppointmentAsString { get; set; }
    }
}
