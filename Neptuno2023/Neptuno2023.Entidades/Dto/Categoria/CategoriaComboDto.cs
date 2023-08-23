using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Dto.Categoria
{
    public class CategoriaComboDto
    {
        private string _NombreCategoria;

        public string NombreCategoria
        {
            get { return _NombreCategoria; }
            set { _NombreCategoria = value; }
        }

    }
}
