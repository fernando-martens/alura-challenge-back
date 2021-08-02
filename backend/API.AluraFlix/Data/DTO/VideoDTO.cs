﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.AluraFlix.Data.DTO
{
    public class VideoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(180)]
        public String Titulo { get; set; }

        public int CategoriaId { get; set; }

        [Required]
        [MaxLength(180)]
        public String Descricao { get; set; }

        [Required]
        public String Url { get; set; }
    }
}

