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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("de9a6882-d28b-4968-a8b3-38c95bdf035e")]
	public partial class IfcCableCarrierFittingType : IfcFlowFittingType
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcCableCarrierFittingTypeEnum _PredefinedType;
	
	
		[Description("Identifies the predefined types of cable carrier fitting from which the type requ" +
	    "ired may be set.")]
		public IfcCableCarrierFittingTypeEnum PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
