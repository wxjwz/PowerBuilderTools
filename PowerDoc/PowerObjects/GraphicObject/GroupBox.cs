// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GroupBox : HardwiredObject {
		static GroupBox instance;

		static GroupBox() {
			instance = new GroupBox();
		}

		static public void Init() {
		}

		public static GroupBox Instance {
			get { return instance; }
		}

		protected GroupBox() : base(PowerObject.PowerObjectParent, "GroupBox", DragObject.Instance) {
		}
	}
}
