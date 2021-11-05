using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEF.Models
{
    [Table("Especialidad")]
    public class Especialidad
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")] //tipo de dato de SQL Server
        [MaxLength(50)] //limitamos los caracteres
        public string Nombre { get; set; }


    }
}
