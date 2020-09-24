﻿using System;
using System.Collections.Generic;

namespace Backend_EveryoneLovesPizza_ADB.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            OrdenVenta = new HashSet<OrdenVenta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<OrdenVenta> OrdenVenta { get; set; }
    }
}
