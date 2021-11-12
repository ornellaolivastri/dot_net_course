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
        public int IdTurno { get; set; }

        // FechaTurno HoraTurno NombreDueño Celular
        
        [Required(ErrorMessage = "Is required")]
        public DateTime FechaTurno  { get; set; }


        [Required(ErrorMessage = "Is required")]
        public TimeSpan HoraTurno { get; set; }
        // TimeSpan (hora:min:seg)


        [Required(ErrorMessage = "Is required")]
        public string NombreDueño { get; set; }


        [Required(ErrorMessage = "Is required")]
        public int Celular { get; set; }


        // NombreMascota RazaMascota(opcional) EdadMascota(opcional)

        [Required(ErrorMessage = "Is required")]
        public string NombreMascota { get; set; }

        public string RazaMascota { get; set; }

        public int EdadMascota { get; set; }


    }

}