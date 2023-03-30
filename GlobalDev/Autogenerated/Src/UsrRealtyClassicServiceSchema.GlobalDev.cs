namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyClassicServiceSchema

	/// <exclude/>
	public class UsrRealtyClassicServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyClassicServiceSchema(UsrRealtyClassicServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c9a912e-219d-4e16-b207-809e27f36f6d");
			Name = "UsrRealtyClassicService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e4be9aa2-faf0-409f-815d-f0053c1c783b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,79,204,44,201,204,75,87,72,203,47,82,8,203,44,46,77,204,81,8,46,41,77,201,204,87,72,206,207,5,10,150,232,1,129,130,166,38,0,139,136,104,27,40,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c9a912e-219d-4e16-b207-809e27f36f6d"));
		}

		#endregion

	}

	#endregion

}

