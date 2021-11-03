﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Olivastri_Ornella.Models
{

    [Table("Vehiculo")]

    public class Auto
    {
        
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Marca { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Modelo { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }

    }
}
