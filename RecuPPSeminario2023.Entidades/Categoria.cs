using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPPSeminario2023.Entidades
{
    public  class Categoria:ICloneable
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
