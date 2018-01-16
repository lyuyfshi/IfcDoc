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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("752102ba-0ec1-4d20-a018-53413630fa9a")]
	public partial class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLengthMeasure? _DisplacementX;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcLengthMeasure? _DisplacementY;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLengthMeasure? _DisplacementZ;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcPlaneAngleMeasure? _RotationalDisplacementRX;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcPlaneAngleMeasure? _RotationalDisplacementRY;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		IfcPlaneAngleMeasure? _RotationalDisplacementRZ;
	
	
		[Description("Displacement in x-direction.")]
		public IfcLengthMeasure? DisplacementX { get { return this._DisplacementX; } set { this._DisplacementX = value;} }
	
		[Description("Displacement in y-direction.")]
		public IfcLengthMeasure? DisplacementY { get { return this._DisplacementY; } set { this._DisplacementY = value;} }
	
		[Description("Displacement in z-direction.")]
		public IfcLengthMeasure? DisplacementZ { get { return this._DisplacementZ; } set { this._DisplacementZ = value;} }
	
		[Description("Rotation about the x-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRX { get { return this._RotationalDisplacementRX; } set { this._RotationalDisplacementRX = value;} }
	
		[Description("Rotation about the y-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRY { get { return this._RotationalDisplacementRY; } set { this._RotationalDisplacementRY = value;} }
	
		[Description("Rotation about the z-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRZ { get { return this._RotationalDisplacementRZ; } set { this._RotationalDisplacementRZ = value;} }
	
	
	}
	
}
