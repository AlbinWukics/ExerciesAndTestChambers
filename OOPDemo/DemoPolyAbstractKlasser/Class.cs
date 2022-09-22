using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolyAbstractKlasser
{
    public abstract class Class
    {
		private int _strength;

		public int Strength
		{
			get { return _strength; }
			set { _strength = value; }
		}

		private int _intelligence;

		public int Intelligence
		{
			get { return _intelligence; }
			set { _intelligence = value; }
		}

		private string _specialWeapon;

		public string SpecialWeapon
		{
			get { return _specialWeapon; }
			set { _specialWeapon = value; }
		}

		private string _className;

		public string ClassName
		{
			get { return _className; }
			set { _className = value; }
		}

        public abstract void Warcry();

        public abstract void PrintClassInfo();
    }
}
