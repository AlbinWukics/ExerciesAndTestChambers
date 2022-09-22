using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FORTS_v._38.Övrigt
{
    public record CarRecord
    {
        private int _topSpeed;

        public int TopSpeed
        {
            get { return _topSpeed; }
            set { _topSpeed = value; }
        }

    }
}
