// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class OleStorage : HardwiredObject {
		static OleStorage instance;

		static OleStorage() {
			instance = new OleStorage();
		}

		static public void Init() {
		}

		public static OleStorage Instance {
			get { return instance; }
		}

		protected OleStorage() : base(PowerObject.PowerObjectParent, "OleStorage", OmStorage.Instance) {
		}
	}
}
