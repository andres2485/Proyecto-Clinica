﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 2)]
        public String Nombres { get; set; }


        [Required(ErrorMessage = "Ingrese un valor")]
        [Range(1, 1000000, ErrorMessage = "Ingrese un valor real ")]

        public long Valor { get; set; }



        [Required]
        public int IdOdontologo { get; set; }
        public virtual Odontologo Odontologo { get; set; }

        [Required]
      

        public int Codigos { get; set; }

        [Required]
       

        public DateTime Horarios { get; set; }

        [Required]
        

        public DateTime FechaCreacion { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Descripcion { get; set; }

        public virtual ICollection<PacienteTratamiento> RegistrosPT { get; set; }  // paciente tratamiento
        public virtual ICollection<Odontologo> Odontologos { get; set; }
    }
}