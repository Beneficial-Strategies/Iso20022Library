// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status Report Content14.
/// </summary>
[IsoId("_mLAtwaE7Ee-MRKYsaX6JDg")]
[DisplayName("Status Report Content14")]
public partial record StatusReportContent14
{
    #nullable enable

    /// <summary>
    /// Attendance Context.
    /// </summary>
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; } 

    /// <summary>
    /// Data Set Required.
    /// </summary>
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public ValueList<DataSetRequest6> DataSetRequired { get; init; } = [];

    /// <summary>
    /// Errors.
    /// </summary>
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    public ValueList<IsoMax140Text> Errors { get; init; } = [];

    /// <summary>
    /// Event.
    /// </summary>
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public ValueList<TMSEvent12> Event { get; init; } = [];

    /// <summary>
    /// POI Capabilities.
    /// </summary>
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 

    /// <summary>
    /// POI Component.
    /// </summary>
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent17> POIComponent { get; init; } = [];

    /// <summary>
    /// POI Date Time.
    /// </summary>
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    public required IsoISODateTime POIDateTime { get; init; } 

    /// <summary>
    /// POI Group Identification.
    /// </summary>
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    public ValueList<IsoMax35Text> POIGroupIdentification { get; init; } = [];

    
    #nullable disable
    
}
