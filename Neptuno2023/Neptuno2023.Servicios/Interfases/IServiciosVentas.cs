using Neptuno2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Interfases
{
    public interface IServiciosVentas
    {
        void Guardar(Venta venta);
        void Borrar(int ventaId);
        bool Existe(Venta venta);
        bool EstaRelacionada(Venta venta);
        int GetCantidad();
        List<Venta> GetCategorias();
        List<Venta> GetCategoriasPorPagina(int cantidad, int pagina);
        Venta GetCategoriaPorId(int ventaId);
    }
}
