// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TraceTreeRoutine : HardwiredObject {
		static TraceTreeRoutine instance;

		static TraceTreeRoutine() {
			instance = new TraceTreeRoutine();
		}

		static public void Init() {
		}

		public static TraceTreeRoutine Instance {
			get { return instance; }
		}

		protected TraceTreeRoutine() : base(PowerObject.PowerObjectParent, "TraceTreeRoutine", TraceTreeNode.Instance) {
		}
	}
}
