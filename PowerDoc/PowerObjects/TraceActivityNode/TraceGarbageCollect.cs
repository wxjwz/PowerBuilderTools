// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TraceGarbageCollect : HardwiredObject {
		static TraceGarbageCollect instance;

		static TraceGarbageCollect() {
			instance = new TraceGarbageCollect();
		}

		static public void Init() {
		}

		public static TraceGarbageCollect Instance {
			get { return instance; }
		}

		protected TraceGarbageCollect() : base(PowerObject.PowerObjectParent, "TraceGarbageCollect", TraceActivityNode.Instance) {
		}
	}
}