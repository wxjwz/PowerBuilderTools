// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class MonCalRepeatType : HardwiredObject {
		static MonCalRepeatType instance;

		static MonCalRepeatType() {
			instance = new MonCalRepeatType();
		}

		static public void Init() {
		}

		public static MonCalRepeatType Instance {
			get { return instance; }
		}

		protected MonCalRepeatType() : base(PowerObject.PowerObjectParent, "MonCalRepeatType", EnumeratedType.Instance) {
		}
	}
}
