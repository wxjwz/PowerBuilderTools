// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TypeCategory : HardwiredObject {
		static TypeCategory instance;

		static TypeCategory() {
			instance = new TypeCategory();
		}

		static public void Init() {
		}

		public static TypeCategory Instance {
			get { return instance; }
		}

		protected TypeCategory() : base(PowerObject.PowerObjectParent, "TypeCategory", EnumeratedType.Instance) {
		}
	}
}