﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTelefono.telefonos.Especificaciones
{
    class Memoria8 : tipotelefono
    {
        tipotelefono _tipotelefono;
        public Memoria8(tipotelefono tipotelefono)
        {
            this._tipotelefono = tipotelefono;
        }
        public override string Descripcion()
        {
            return "Memoria de 8gb";
        }

        public override double Precio()
        {
            return 40;
        }
    }
}
