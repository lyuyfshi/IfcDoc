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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("610bae35-1be6-4a90-ad4e-102a28b67208")]
	public partial class IfcAxis2Placement3D : IfcPlacement,
		BuildingSmart.IFC.IfcGeometryResource.IfcAxis2Placement
	{
		[DataMember(Order=0)] 
		IfcDirection _Axis;
	
		[DataMember(Order=1)] 
		IfcDirection _RefDirection;
	
	
		[Description("The exact direction of the local Z Axis.")]
		public IfcDirection Axis { get { return this._Axis; } set { this._Axis = value;} }
	
		[Description("The direction used to determine the direction of the local X Axis. If necessary a" +
	    "n adjustment is made to maintain orthogonality to the Axis direction. If Axis an" +
	    "d/or RefDirection is omitted, these directions are taken from the geometric coor" +
	    "dinate system.")]
		public IfcDirection RefDirection { get { return this._RefDirection; } set { this._RefDirection = value;} }
	
		public new IList<IfcDirection> P { get { return null; } }
	
	
	}
	
}
