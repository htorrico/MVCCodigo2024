﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodigo2024.Models
{
    public class PersonaModel
    {
        public int PersonaID { get; set; }
        public int Edad { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }
    }
}