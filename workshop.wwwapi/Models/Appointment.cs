﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly
    [Table("appointments")]
    public class Appointment
    {
        //[Key]
        //public int Id { get; set; }


        [Column("date", TypeName = "timestamp")]
        public DateTime Booking { get; set; }

        [Column("doctor_id")]
        [ForeignKey("doctors")]
        public int DoctorId { get; set; }

        [Column("patient_id")]
        [ForeignKey("patients")]
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

    }
}
