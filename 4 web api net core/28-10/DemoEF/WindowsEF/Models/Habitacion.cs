using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEF.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        [Required]
        [Column(TypeName = "varchar")] //tipo de dato de SQL Server
        [MaxLength(12)] //limitamos los caracteres
        public string Estado { get; set; }

        public int ClinicaId { get; set; }

        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }


    }
}
