// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class DivideByZeroError : HardwiredObject {
		static DivideByZeroError instance;

		static DivideByZeroError() {
			instance = new DivideByZeroError();
		}

		static public void Init() {
		}

		public static DivideByZeroError Instance {
			get { return instance; }
		}

		protected DivideByZeroError() : base(PowerObject.PowerObjectParent, "DivideByZeroError", RuntimeError.Instance) {
		}
	}
}