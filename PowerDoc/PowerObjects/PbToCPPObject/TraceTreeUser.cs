// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TraceTreeUser : HardwiredObject {
		static TraceTreeUser instance;

		static TraceTreeUser() {
			instance = new TraceTreeUser();
		}

		static public void Init() {
		}

		public static TraceTreeUser Instance {
			get { return instance; }
		}

		protected TraceTreeUser() : base(PowerObject.PowerObjectParent, "TraceTreeUser", TraceTreeNode.Instance) {
		}
	}
}