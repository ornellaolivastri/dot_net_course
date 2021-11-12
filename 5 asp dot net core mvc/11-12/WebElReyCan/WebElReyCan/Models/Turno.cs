using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebElReyCan.Models
{
    [Table("Turno")]

    public class Turno
    {
        [Key]
        public int Id { get; set; }

        // FechaTurno HoraTurno NombreDueño Celular
        
        [Required(ErrorMessage = "Is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Fecha  { get; set; }


        [Required(ErrorMessage = "Is required")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public string Hora { get; set; }
        // TimeSpan (hora:min:seg)


        [Required(ErrorMessage = "Is required")]
        public string NombreDuenio { get; set; }


        [Required(ErrorMessage = "Is required")]
        public int Celular { get; set; }


        // NombreMascota RazaMascota(opcional) EdadMascota(opcional)

        [Required(ErrorMessage = "Is required")]
        public string NombreMascota { get; set; }

        public string Raza { get; set; }

        public int Edad { get; set; }


    }

}