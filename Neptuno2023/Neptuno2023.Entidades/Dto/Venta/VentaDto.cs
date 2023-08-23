using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Dto.Venta
{
    public class VentaDto
    {
        private int _VentaId;
        private decimal _Total;
        private int _ClienteId;
        private DateTime _FechaVenta;

        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }
        public int ClienteId
        {
            get { return _ClienteId; }
            set { _ClienteId = value; }
        }


        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public int VentaId
        {
            get { return _VentaId; }
            set { _VentaId = value; }
        }
    }
}
