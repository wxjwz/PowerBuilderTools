// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TrigEvent : HardwiredObject {
		static TrigEvent instance;

		static TrigEvent() {
			instance = new TrigEvent();
		}

		static public void Init() {
		}

		public static TrigEvent Instance {
			get { return instance; }
		}

		protected TrigEvent() : base(PowerObject.PowerObjectParent, "TrigEvent", EnumeratedType.Instance) {
		}
	}
}
