using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{

    //decoraciones para personalizar el esquema de la tabla

    [Table("Paciente")]
    ///EF cuando crea la tabla la llama Paciente en singular sino por
    ///convensión pluraliza el nombre "Pacientes"

    //---------------------

    public class Paciente
    {
       

        #region propiedades

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")] //tipo de dato de SQL Server
        [MaxLength(50)] //limitamos los caracteres
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")] //tipo de dato de SQL Server
        [MaxLength(50)] //limitamos los caracteres
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int NroHistoriaClinica { get; set; }

        #endregion

        public int MedicoId { get; set; }//FK clave externa

        //Propiedad de navegación
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }


    }
}
