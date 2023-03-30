namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9148f597-c90e-4dac-a4d8-0578f4ade9b1");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e4be9aa2-faf0-409f-815d-f0053c1c783b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,79,194,64,16,133,239,253,21,147,198,67,155,144,6,175,162,36,130,104,72,140,26,1,47,198,195,178,29,234,154,237,110,179,187,69,209,240,223,157,237,130,80,224,224,156,154,233,155,111,223,155,140,98,37,218,138,113,132,41,26,195,172,94,184,108,168,213,66,20,181,97,78,104,21,253,68,64,85,91,161,10,152,172,172,195,178,183,215,217,159,50,152,141,148,19,78,160,253,135,36,27,45,81,185,141,242,181,233,174,154,214,189,160,71,20,154,100,194,223,177,100,15,228,16,174,32,158,89,243,140,76,186,213,80,50,107,5,143,211,183,102,180,170,231,82,112,224,190,11,65,113,2,6,23,48,96,22,79,252,105,32,33,228,30,78,47,201,181,200,17,150,90,228,240,168,198,202,162,113,20,39,209,243,15,228,14,44,170,28,77,7,2,113,128,11,202,214,112,175,77,97,1,211,63,224,14,237,107,78,38,178,125,220,150,131,105,175,37,12,92,48,77,32,202,159,132,70,26,244,109,109,142,92,148,76,66,101,4,247,187,10,67,217,29,186,233,170,194,124,168,101,93,170,23,38,107,188,220,72,251,137,223,231,147,215,207,38,55,241,193,219,98,1,73,96,245,225,188,187,173,180,165,105,199,242,133,217,216,14,153,226,40,49,39,19,206,212,216,59,18,89,103,252,77,208,209,89,86,224,20,203,74,50,71,158,143,132,190,54,57,102,180,43,186,73,69,107,167,131,244,177,238,53,103,82,124,179,185,196,73,3,76,118,231,17,206,42,238,64,220,36,30,219,169,214,3,81,28,102,60,54,67,158,67,35,187,213,166,100,46,57,48,73,196,243,172,59,56,59,69,114,239,70,127,130,194,79,24,125,113,172,188,207,237,248,129,122,29,181,191,214,81,180,254,5,26,61,125,252,133,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9e75c8b5-07fd-441c-c5f0-eede4814ce6e"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("e4be9aa2-faf0-409f-815d-f0053c1c783b"),
				CreatedInSchemaUId = new Guid("9148f597-c90e-4dac-a4d8-0578f4ade9b1"),
				ModifiedInSchemaUId = new Guid("9148f597-c90e-4dac-a4d8-0578f4ade9b1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9148f597-c90e-4dac-a4d8-0578f4ade9b1"));
		}

		#endregion

	}

	#endregion

}

