// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class InkPenTip : HardwiredObject {
		static InkPenTip instance;

		static InkPenTip() {
			instance = new InkPenTip();
		}

		static public void Init() {
		}

		public static InkPenTip Instance {
			get { return instance; }
		}

		protected InkPenTip() : base(PowerObject.PowerObjectParent, "InkPenTip", EnumeratedType.Instance) {
		}
	}
}
