﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly    
    [Table("patients")]
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string FullName { get; set; }

        //[ForeignKey(nameof(Appointments))]
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
