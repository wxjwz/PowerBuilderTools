// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class NonVisualObject : HardwiredObject {
		static NonVisualObject instance;

		static NonVisualObject() {
			instance = new NonVisualObject();
		}

		static public void Init() {
		}

		public static NonVisualObject Instance {
			get { return instance; }
		}

		protected NonVisualObject() : base(PowerObject.PowerObjectParent, "NonVisualObject", PowerObject.PowerObjectInstance) {
		}
	}
}
