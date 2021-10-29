using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    public class Medico
    {

        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }

        //propiedad de navegación
        public List<Paciente> Pacientes { get; set; }

        /* esto no iba :C
         * 
        //Foreign Key a Especialidad
        public int EspecialidadId { get; set; }

        //esta es la relacion, que conecta la tabla medico con la tabla especialidad
        //se debe clarar aqui una de las llaves y en la otra tabla la otra
        [ForeignKey("EspecialidadId")]

        public Especialidad Especialidad { get; set; }
        [ForeignKey("EspecialidadId")]

        public List<Medico> medicos { get; set; }
        */

    }

}
