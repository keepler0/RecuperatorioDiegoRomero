using Neptuno2023.Entidades.Entidades;
using Neptuno2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Servicios
{
    public class ServiciosVentas : IServiciosVentas
    {
        public void Borrar(int ventaId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionada(Venta venta)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Venta venta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            throw new NotImplementedException();
        }

        public Venta GetCategoriaPorId(int ventaId)
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetCategoriasPorPagina(int cantidad, int pagina)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
