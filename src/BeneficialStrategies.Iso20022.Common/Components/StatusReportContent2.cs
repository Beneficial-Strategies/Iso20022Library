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
[IsoId("_NoKsEQyVEeK5P9Ihqok3VA")]
[DisplayName("Status Report Content")]
public partial record StatusReportContent2
{
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI performing the status report.
    /// </summary>
    [IsoId("_N00oAQyVEeK5P9Ihqok3VA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities1? POICapabilities { get; init; } 
    
    /// <summary>
    /// Data related to a component of the POI performing the status report.
    /// </summary>
    [IsoId("_N00oBQyVEeK5P9Ihqok3VA")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent3? POIComponent { get; init; } 
    
    /// <summary>
    /// Human attendance at the POI location during transactions.
    /// </summary>
    [IsoId("_N00oCQyVEeK5P9Ihqok3VA")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    
    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_N00oDQyVEeK5P9Ihqok3VA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; } 
    
    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_N00oEQyVEeK5P9Ihqok3VA")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public TerminalManagementDataSet7? DataSetRequired { get; init; } 
    
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_N00oFQyVEeK5P9Ihqok3VA")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public TMSEvent2? Event { get; init; } 
    
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_N00oGQyVEeK5P9Ihqok3VA")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Errors { get; init; } 
    
    
    #nullable disable
    
}
