// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class DragObject : HardwiredObject {
		static DragObject instance;

		static DragObject() {
			instance = new DragObject();
		}

		static public void Init() {
		}

		public static DragObject Instance {
			get { return instance; }
		}

		protected DragObject() : base(PowerObject.PowerObjectParent, "DragObject", WindowObject.Instance) {
		}
	}
}