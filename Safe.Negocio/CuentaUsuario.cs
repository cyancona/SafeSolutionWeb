﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.Negocio
{
    public class CuentaUsuario
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int habilitado { get; set; }
        public int rol { get; set; }

        public CuentaUsuario()
        {
            this.Init();
        }

        private void Init()
        {
            this.username = string.Empty;
            this.password = string.Empty;
            this.habilitado = 0;
            this.rol = 0;
        }

        public string Serializar()
        {
            return ClaseComun.Serializar(this);
        }

        public static CuentaUsuario Deserializar(string json)
        {
            return (CuentaUsuario)ClaseComun.Deserializar<CuentaUsuario>(json);
        }
    }
}
