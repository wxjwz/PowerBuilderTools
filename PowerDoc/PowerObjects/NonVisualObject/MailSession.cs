// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class MailSession : HardwiredObject {
		static MailSession instance;

		static MailSession() {
			instance = new MailSession();
		}

		static public void Init() {
		}

		public static MailSession Instance {
			get { return instance; }
		}

		protected MailSession() : base(PowerObject.PowerObjectParent, "MailSession", NonVisualObject.Instance) {
		}
	}
}