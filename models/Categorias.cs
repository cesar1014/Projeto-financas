﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.models
{
    public class Categorias
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string descricao { get; set; }  
        public string tipo { get; set; }
    }
}
