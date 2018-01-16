// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcCostResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("0c523651-bc17-41eb-b22e-d09db16fe089")]
	public partial class IfcProcedure : IfcProcess
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcIdentifier _ProcedureID;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcProcedureTypeEnum _ProcedureType;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLabel? _UserDefinedProcedureType;
	
	
		[Description("An identifying designation given to a procedure.")]
		public IfcIdentifier ProcedureID { get { return this._ProcedureID; } set { this._ProcedureID = value;} }
	
		[Description("Predefined procedure types from which that required may be set. ")]
		public IfcProcedureTypeEnum ProcedureType { get { return this._ProcedureType; } set { this._ProcedureType = value;} }
	
		[Description("A user defined procedure type.")]
		public IfcLabel? UserDefinedProcedureType { get { return this._UserDefinedProcedureType; } set { this._UserDefinedProcedureType = value;} }
	
	
	}
	
}
