using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FORTS_v._38
{
    public class CarClass : VehicleClass
    {
		private int _mumberOfDoors;

		public int NumberOfDoors
		{
			get { return _mumberOfDoors; }
			set { _mumberOfDoors = value; }
		}


	}
}
