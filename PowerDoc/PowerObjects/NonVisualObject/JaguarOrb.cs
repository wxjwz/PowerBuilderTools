// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class JaguarOrb : HardwiredObject {
		static JaguarOrb instance;

		static JaguarOrb() {
			instance = new JaguarOrb();
		}

		static public void Init() {
		}

		public static JaguarOrb Instance {
			get { return instance; }
		}

		protected JaguarOrb() : base(PowerObject.PowerObjectParent, "JaguarOrb", Orb.Instance) {
		}
	}
}
