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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcQuantityResource;

namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("94dc877b-0f35-43d9-97af-b81360e8f4e0")]
	public enum IfcPermitTypeEnum
	{
		ACCESS = 1,
	
		BUILDING = 2,
	
		WORK = 3,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}