// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the status report.
/// </summary>
[IsoId("_LYUz5X1DEeCF8NjrBemJWQ_2097430790")]
[DisplayName("Status Report Content")]
public partial record StatusReportContent1
{
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI performing the status report.
    /// </summary>
    [IsoId("_LYUz5n1DEeCF8NjrBemJWQ_596399670")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities1? POICapabilities { get; init; } 
    
    /// <summary>
    /// Data related to a component of the POI performing the status report.
    /// </summary>
    [IsoId("_LYUz531DEeCF8NjrBemJWQ_-1136419179")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent2? POIComponent { get; init; } 
    
    /// <summary>
    /// Human attendance at the POI location during transactions.
    /// </summary>
    [IsoId("_LYUz6H1DEeCF8NjrBemJWQ_1775972166")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    
    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_LYek4H1DEeCF8NjrBemJWQ_1465251425")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; } 
    
    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_LYek4X1DEeCF8NjrBemJWQ_1168498842")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public DataSetIdentification2? DataSetRequired { get; init; } 
    
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_LYek4n1DEeCF8NjrBemJWQ_-1121153911")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public TMSEvent1? Event { get; init; } 
    
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_LYek431DEeCF8NjrBemJWQ_-633647435")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Errors { get; init; } 
    
    
    #nullable disable
    
}
