// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TraceFile : HardwiredObject {
		static TraceFile instance;

		static TraceFile() {
			instance = new TraceFile();
		}

		static public void Init() {
		}

		public static TraceFile Instance {
			get { return instance; }
		}

		protected TraceFile() : base(PowerObject.PowerObjectParent, "TraceFile", PbToCPPObject.Instance) {
		}
	}
}
