// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Error : HardwiredObject {
		static Error instance;

		static Error() {
			instance = new Error();
		}

		static public void Init() {
		}

		public static Error Instance {
			get { return instance; }
		}

		protected Error() : base(PowerObject.PowerObjectParent, "Error", NonVisualObject.Instance) {
		}
	}
}
