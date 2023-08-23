using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Entidades
{
	public class Venta
	{
		private int _VentaId;
		private int _ClienteId;
		private DateTime _FechaVenta;
		private decimal _Total;
		private byte[] _RowVersion;

		public byte[] RowVersion
		{
			get { return _RowVersion; }
			set { _RowVersion = value; }
		}

		public decimal Total
		{
			get { return _Total; }
			set { _Total = value; }
		}


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

		public int VentaId
		{
			get { return _VentaId; }
			set { _VentaId = value; }
		}

	}
}
