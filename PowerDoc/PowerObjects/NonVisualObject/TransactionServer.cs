// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class TransactionServer : HardwiredObject {
		static TransactionServer instance;

		static TransactionServer() {
			instance = new TransactionServer();
		}

		static public void Init() {
		}

		public static TransactionServer Instance {
			get { return instance; }
		}

		protected TransactionServer() : base(PowerObject.PowerObjectParent, "TransactionServer", Service.Instance) {
		}
	}
}