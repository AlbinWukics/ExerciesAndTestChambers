using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FORTS_v._38
{
    public class MotorcycleClass : VehicleClass
    {
		private string _handleBarType = String.Empty;

		public string HandleBarType
		{
			get { return _handleBarType; }
			set { _handleBarType = value; }
		}

	}
}
